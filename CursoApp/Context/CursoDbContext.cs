using CursoApp.Models;
using Microsoft.EntityFrameworkCore;

namespace CursoApp.Context
{
    public class CursoDbContext : DbContext
    {
        public CursoDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Cursos> Cursos { get; set; }

        public DbSet<Profesores>? Profesores { get; set; }

        public DbSet<Estudiantes>? Estudiantes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("conexion");
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
