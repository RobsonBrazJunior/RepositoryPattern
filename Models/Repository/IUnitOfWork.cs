namespace Models.Repository
{
    public interface IUnitOfWork
    {
        ICategoriaProdutoRepository CategoriaProduto { get; }
        IProdutoRepository Produto { get; }
        void Save();
    }
}
