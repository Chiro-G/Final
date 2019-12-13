using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TrabajoFinal.Models;

namespace TrabajoFinal.Data
{
    public class TrabajoFinalContext : DbContext
    {
        public TrabajoFinalContext (DbContextOptions<TrabajoFinalContext> options)
            : base(options)
        {
        }

        public DbSet<TrabajoFinal.Models.Docente> Docente { get; set; }
    }
}
