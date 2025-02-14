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
            modelBuilder.Entity<Produto>().HasKey(c => c.IdProduto);
            modelBuilder.Entity<Produto>().Property(propertyExpression: static c => c.IdProduto).ValueGeneratedOnAdd();
            modelBuilder.Entity<Fornecedor>().HasKey(c => c.CodigoF);
            modelBuilder.Entity<Fornecedor>().Property(propertyExpression: static c => c.CodigoF).ValueGeneratedOnAdd();
            modelBuilder.Entity<Entrada>().HasKey(c => c.IdEntrada);
            modelBuilder.Entity<Entrada>().Property(propertyExpression: static c => c.IdEntrada).ValueGeneratedOnAdd();
            modelBuilder.Entity<Secretaria>().HasKey(c => c.IdSecretaria);
            modelBuilder.Entity<Secretaria>().Property(propertyExpression: static c => c.IdSecretaria).ValueGeneratedOnAdd();
            modelBuilder.Entity<Saida>().HasKey(c => c.IdSaida);
            modelBuilder.Entity<Saida>().Property(propertyExpression: static c => c.IdSaida).ValueGeneratedOnAdd();
            modelBuilder.Entity<ItensDeSaida>().HasKey(c => c.IdItensDeSaida);
            modelBuilder.Entity<ItensDeSaida>().Property(propertyExpression: static c => c.IdItensDeSaida).ValueGeneratedOnAdd();
            modelBuilder.Entity<ItensDeEntrada>().HasKey(c => c.IdItensDeEntrada);
            modelBuilder.Entity<ItensDeEntrada>().Property(propertyExpression: static c => c.IdItensDeEntrada).ValueGeneratedOnAdd();

        }
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Produto> Produto { get; set; }
        public DbSet<Fornecedor> Fornecedor { get; set; }
        public DbSet<Entrada> Entrada { get; set; }
        public DbSet<ItensDeEntrada> ItensDeEntradas { get; set; }
        public DbSet<Saida> Saida { get; set; }
        public DbSet<Secretaria> Secretaria { get; set; }
        public DbSet<ItensDeSaida> ItensDeSaida { get; set; }
    }
}
