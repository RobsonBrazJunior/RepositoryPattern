using Call;
using Models.Entities;
using Models.Repository;
using System;
using System.Linq;

namespace RepositoryPattern
{
    public class Program
    {
        private static IUnitOfWork contexto;

        static void Main()
        {
            contexto = new UnitOfWork();

            List();

            Create();
            List();

            Update();
            List();

            Delete();
            List();

            Console.ReadLine();
        }

        private static void List()
        {
            Console.WriteLine("======= LISTAGEM DE PRODUTOS =======");
            foreach (var produto in contexto.Produto.GetAll())
            {
                Console.WriteLine("Id: {0}, Descricao: {1}, Categoria: {2}, Data Cadastro: {3:d}, Valor Unitário: {4:n2}",
                    produto.Id, produto.Descricao, produto.Categoria.Nome, produto.DataCadastro, produto.ValorUnitario);
            }
            Console.WriteLine("====================================");
        }

        private static void Create()
        {
            var novoProduto = new Produto
            {
                Descricao = "Novo produto",
                Categoria = contexto.CategoriaProduto.GetAll().First(),
                DataCadastro = DateTime.Now,
                ValorUnitario = 2.34m
            };

            contexto.Produto.Add(novoProduto);
            contexto.Save();

            Console.WriteLine("====================================");
            Console.WriteLine("PRODUTO CADASTRADO COM SUCESSO");
            Console.WriteLine("====================================");
        }

        private static void Update()
        {
            var produto = contexto.Produto.GetAll().Last();
            produto.Descricao = "Produto alterado";
            contexto.Save();

            Console.WriteLine("====================================");
            Console.WriteLine("PRODUTO ALTERADO COM SUCESSO");
            Console.WriteLine("====================================");
        }

        private static void Delete()
        {
            var produto = contexto.Produto.GetAll().Last();
            contexto.Produto.Remove(produto);
            contexto.Save();

            Console.WriteLine("====================================");
            Console.WriteLine("PRODUTO EXCLUÍDO COM SUCESSO");
            Console.WriteLine("====================================");
        }
    }
}
