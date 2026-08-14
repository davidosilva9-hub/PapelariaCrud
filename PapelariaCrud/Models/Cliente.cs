using Microsoft.AspNetCore.Authorization;
using System.ComponentModel.DataAnnotations;

namespace PapelariaCrud.Models
{
    public class Cliente
    {
        [Key]
            public int IdCliente { get; set; }
        
            public string Nome { get; set; }

            public string CPF { get; set; }

            public string Telefone { get; set; }

            [EmailAddress]
            public string Email { get; set; }
        }
    }


