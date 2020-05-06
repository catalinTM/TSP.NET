using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Asp_Muntean_CatalinTudor_Rp.Models;

namespace Asp_Muntean_CatalinTudor_Rp.Data
{
    public class Asp_Muntean_CatalinTudor_RpContext : DbContext
    {
        public Asp_Muntean_CatalinTudor_RpContext (DbContextOptions<Asp_Muntean_CatalinTudor_RpContext> options)
            : base(options)
        {
        }

        public DbSet<Asp_Muntean_CatalinTudor_Rp.Models.Movie> Movie { get; set; }
    }
}
