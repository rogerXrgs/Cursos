using Microsoft.EntityFrameworkCore;
using MyWebApp.Entidades;

namespace MyWebApp
{
    public class MyWebAppContex : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<ItemPedido> ItensPedidos { get; set; }

        public MyWebAppContex(DbContextOptions<MyWebAppContex> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produto>().HasKey(p => p.Id);
            modelBuilder.Entity<Pedido>().HasKey(p => p.Id);
            modelBuilder.Entity<ItemPedido>().HasKey(p => p.Id);
            base.OnModelCreating(modelBuilder);
        }

        public override int SaveChanges()
        {
            ChangeTracker.DetectChanges();
            return base.SaveChanges();
        }
    }
}
