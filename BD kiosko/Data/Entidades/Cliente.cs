using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD_kiosko.Data.Entidades
{
    //[Index(nameof(Idcliente), Name = "DNI_UQ", IsUnique = true)]
    public class Cliente :Entity_base
    {
        public int Idcliente { get; set; }

        public string Nombre { get; set; }

        public int Cuando_Deben { get; set; }

        
    }
}
