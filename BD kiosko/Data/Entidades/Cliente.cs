using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD_kiosko.Data.Entidades
{
    [Index(nameof(DNI), Name = "DNI_UQ", IsUnique = true)]
    public class Cliente :Entity_base
    {
        public int DNI { get; set; }

        public string Nombre { get; set; }

        
    }
}
