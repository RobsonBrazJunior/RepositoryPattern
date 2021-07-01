using Models.Entities;
using Models.Repository;

namespace InMemory
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly CategoriaProdutoRepository _categoriaProduto = new();
        private readonly ProdutoRepository _produto = new();

        public ICategoriaProdutoRepository CategoriaProduto { get { return _categoriaProduto; } }

        public IProdutoRepository Produto { get { return _produto; } }

        public UnitOfWork()
        {
            _categoriaProduto.Add(new CategoriaProduto() { Id = 1, Nome = "Categoria 1"});
            _categoriaProduto.Add(new CategoriaProduto() { Id = 2, Nome = "Categoria 2"});
            _categoriaProduto.Add(new CategoriaProduto() { Id = 3, Nome = "Categoria 3"});
        }

        public void Save()
        {
        }
    }
}
