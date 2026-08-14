using System.ComponentModel.DataAnnotations;

namespace PapelariaCrud.Models
{
    public class Produto
    {
        [Key]
        public int IdProduto { get; set; }

        public string Nome { get; set; }

        public string Categoria { get; set; }

        public decimal Preco { get; set; }

        public int QuantidadeEstoque { get; set; }
    }
}
