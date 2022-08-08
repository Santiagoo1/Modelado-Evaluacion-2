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
        public BDcontextkiosko(DbContextOptions options) : base(options)
        {

        }
    }
}
