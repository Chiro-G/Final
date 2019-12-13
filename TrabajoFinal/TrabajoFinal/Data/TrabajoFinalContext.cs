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
        public DbSet<Estudiante> Estudiantes { get; set; }
        public DbSet<Docente> Docentes { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Modulo> Modulos { get; set; }
        public DbSet<Pago> Pagos { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Estudiante>().ToTable("Estudiante");
            modelBuilder.Entity<Docente>().ToTable("Docente");
            modelBuilder.Entity<Curso>().ToTable("Curso");
            modelBuilder.Entity<Modulo>().ToTable("Modulo");
            modelBuilder.Entity<Pago>().ToTable("Pago");
        }
        public DbSet<TrabajoFinal.Models.Docente> Docente { get; set; }
    }
}
