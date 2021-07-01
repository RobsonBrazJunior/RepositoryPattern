using Models.Entities;
using Models.Repository;
using System.Collections.Generic;
using System.Linq;

namespace Call
{
    public class ProdutoRepository : Repository<Produto>, IProdutoRepository
    {
        public override void Add(Produto entity)
        {
            if (entity.Id == 0)
            {
                entity.Id = GetMax() + 1;
            }

            base.Add(entity);
        }

        public IEnumerable<Produto> GetProdutosPorCategoria(CategoriaProduto categoria)
        {
            return _lista.Where(p => p.Categoria == categoria).AsEnumerable();
        }

        private int GetMax()
        {
            var maxId = 0;

            if (_lista.Any())
            {
                maxId = _lista.Max(p => p.Id);
            }

            return maxId;
        }
    }
}
