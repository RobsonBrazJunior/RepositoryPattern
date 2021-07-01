using System;

namespace Models.Entities
{
    public class Produto
    {
        public int Id { get; set; }

        public string Descricao { get; set; }

        public CategoriaProduto Categoria { get; set; }

        public int CategoriaId { get; set; }

        public DateTime DataCadastro { get; set; }

        public decimal ValorUnitario { get; set; }
    }
}
