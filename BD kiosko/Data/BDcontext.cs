using BD_kiosko.Data.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD_kiosko.Data
{
    public class BDcontextkiosko:DbContext
    {
        public DbSet<Cliente> clientes { get; set; }
        public BDcontextkiosko(DbContextOptions options) : base(options)
        {

        }
    }
}
