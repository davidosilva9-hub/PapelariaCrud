using System.ComponentModel.DataAnnotations;

namespace PapelariaCrud.Models
{
    public class Fornecedor
    {
        [Key]
        public int IdFornecedor{ get; set; }

        public string Nome { get; set; }

        public string CNPJ { get; set; }

        public string Telefone { get; set; }

        [EmailAddress]
        public string Email { get; set; }
    }
}
