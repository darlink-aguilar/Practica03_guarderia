using Microsoft.EntityFrameworkCore;
using Practica03_guarderia.Nucleo;

namespace parcial
{
    public class Conexion : DbContext
    {
        public string? StringConnection { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(this.StringConnection!, p => { });
            optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
        }

        public DbSet<Sucursales>? Sucursales { get; set; }
        public DbSet<Profesores>? Profesores { get; set; }
    }
}