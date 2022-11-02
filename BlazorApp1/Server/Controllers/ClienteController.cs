using BD_kiosko.Data.Entidades;
using BD_kiosko.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.Server.Controllers
{
    [Route("api/Clientes")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly BDcontextkiosko context;

        public ClienteController(BDcontextkiosko context)
        {
            this.context = context;
        }
        [HttpPost]
        public async Task<ActionResult<int>> Post(Cliente Registrar)
        {
            try
            {
                context.clientes.Add(Registrar);
                await context.SaveChangesAsync();
                return Registrar.ID;
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet]
        
        public async Task<ActionResult<List<Cliente>>> Get()
        {
            var resp = await context.clientes.ToListAsync();
            return resp;
        }
       

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Cliente>> Get(int id)
        {

            var Registro = await context.clientes.FindAsync(id);
            if (Registro == null)
            {
                return NotFound($"No existe venta de id: {id}");
            }
            return Registro;
        }
        [HttpPut("{id:int}")]
        public ActionResult Put(int id, [FromBody] Cliente client)
        {
            if (id != client.ID)
            {
                return BadRequest("Datos Incorrectos");
            }

            var Cliente = context.clientes.Where(e => e.ID == id).FirstOrDefault();

            if (Cliente == null)
            {
                return NotFound("No existe la venta buscada");
            }
            Cliente.Nombre = client.Nombre;
            Cliente.Idcliente = client.Idcliente;
            Cliente.Cuando_Deben = client.Cuando_Deben;
            
            try
            {
                context.clientes.Update(Cliente);
                context.SaveChanges();
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest($"Los datos no han sido actualizados por: {e.Message}");
            }
        }
        [HttpDelete("{id:int}")]
        public ActionResult Delete(int id)
        {
            var cliente = context.clientes.Where(x => x.ID == id).FirstOrDefault();


            if (cliente == null)
            {
                return NotFound($"El registro {id} no fue encontrado");
            }
            try
            {


                context.clientes.Remove(cliente);

                context.SaveChanges();
                return Ok($"El registro de {cliente.ID} ha sido borrado.");
            }
            catch (Exception e)
            {
                return BadRequest($"Los datos no pudieron eliminarse por: {e.Message}");
            }
        }
    }
    }
