using Kaelo.Models;
using Microsoft.EntityFrameworkCore;

namespace Kaelo.DAL
{
    public class ProdutoContext : DbContext
    {
        public ProdutoContext(DbContextOptions options) : base(options){ }

        public ProdutoContext(){ }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("InMemoryProvider");
        }

        public DbSet<Produto> Produtos { get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produto>().HasKey(c => c.IdProduto);
        }
    }
}
