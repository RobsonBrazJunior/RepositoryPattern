using Models.Entities;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;

namespace ORM
{
    internal class Contexto : DbContext
    {
        public DbSet<CategoriaProduto> CategoriaProduto { get; set; }
        public DbSet<Produto> Produto { get; set; }

        public Contexto() : base()
        {
            if (!CategoriaProduto.Any())
            {
                CategoriaProduto.Add(new CategoriaProduto() { Id = 1, Nome = "Categoria 1" });
                CategoriaProduto.Add(new CategoriaProduto() { Id = 2, Nome = "Categoria 2" });
                CategoriaProduto.Add(new CategoriaProduto() { Id = 3, Nome = "Categoria 3" });
                SaveChanges();
            }
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
