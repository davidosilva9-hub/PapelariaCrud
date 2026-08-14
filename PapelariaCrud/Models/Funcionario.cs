using System.ComponentModel.DataAnnotations;

namespace PapelariaCrud.Models
{
    public class Funcionario
    {
        [Key]
        public int IdFuncionario { get; set; }

        public string Nome { get; set; }

        public string CPF { get; set; }

        public string Cargo { get; set; }

        public string Telefone { get; set; }
    }
}
