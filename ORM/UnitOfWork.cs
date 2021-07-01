using Models.Repository;

namespace ORM
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly Contexto _contexto;
        private readonly ICategoriaProdutoRepository _categoriaProduto;
        private readonly IProdutoRepository _produto;

        public ICategoriaProdutoRepository CategoriaProduto { get { return _categoriaProduto; } }

        public IProdutoRepository Produto { get { return _produto; } }

        public UnitOfWork()
        {
            _contexto = new Contexto();
            _categoriaProduto = new CategoriaProdutoRepository(_contexto.CategoriaProduto);
            _produto = new ProdutoRepository(_contexto.Produto);
        }

        public void Save()
        {
            _contexto.SaveChanges();
        }
    }
}
