using Models.Entities;
using Models.Repository;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace ORM
{
    public class ProdutoRepository : Repository<Produto>, IProdutoRepository
    {
        public ProdutoRepository(DbSet<Produto> dbSet) : base(dbSet) { }

        public IEnumerable<Produto> GetProdutosPorCategoria(CategoriaProduto categoria)
        {
            return _dbSet.Where(p => p.Categoria == categoria).AsEnumerable();
        }
    }
}
