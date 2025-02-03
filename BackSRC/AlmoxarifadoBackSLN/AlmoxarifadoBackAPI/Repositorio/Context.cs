using AlmoxarifadoBackAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace AlmoxarifadoBackAPI.Repositorio
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categoria>().HasKey(c=>c.Codigo);
            modelBuilder.Entity<Categoria>().Property(c => c.Codigo).ValueGeneratedOnAdd();

        }
        public DbSet<Categoria> Categoria { get; set; }

        public Context(DbContextOptions<Context> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produto>().HasKey(c => c.IdProduto);
            modelBuilder.Entity<Produto>().Property(propertyExpression: static c => c.IdProduto).ValueGeneratedOnAdd();

        }
        public DbSet<Produto> Produtos { get; set; }

    }
}
