using Microsoft.EntityFrameworkCore;
using FerreSoft.Shared.Entities;

namespace FerreSoft.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        
        public DbSet<Usuario> Usuario{ get; set; }

        public DbSet<Cliente> Cliente { get; set; }

        public DbSet<Vendedor> Vendedor { get; set; }

        public DbSet<Pedido> Pedido { get; set; }

        public DbSet<DetallesPedido> DetallesPedidos { get; set; }

        public DbSet<Producto> Productos { get; set; }

        public DbSet<Stock> Stocks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Usuario>().HasIndex(c => c.Nombre).IsUnique();
            modelBuilder.Entity<Usuario>().HasIndex(c => c.Nombre).IsUnique();
        }
    }
}
