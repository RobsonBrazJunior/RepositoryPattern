using Models.Entities;
using System.Collections.Generic;

namespace Models.Repository
{
    public interface IProdutoRepository : IRepository<Produto>
    {
        IEnumerable<Produto> GetProdutosPorCategoria(CategoriaProduto categoria);
    }
}
