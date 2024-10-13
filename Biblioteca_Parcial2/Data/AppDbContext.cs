using Biblioteca_Parcial2.Models;
using Microsoft.EntityFrameworkCore;

namespace Biblioteca_Parcial2.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Producto> Productos { get; set; }

        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Pedidos> Pedidos { get; set; }
    }
}
