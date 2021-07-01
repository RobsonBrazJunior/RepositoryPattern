using Models.Entities;
using Models.Repository;
using System.Data.Entity;

namespace ORM
{
    public class CategoriaProdutoRepository : Repository<CategoriaProduto>, ICategoriaProdutoRepository
    {
        public CategoriaProdutoRepository(DbSet<CategoriaProduto> dbSet) : base(dbSet) { }
    }
}
