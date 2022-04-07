using System;
using System.ComponentModel.DataAnnotations;

namespace SistemaLocacao.Models
{
    public class ClienteModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Digite o nome do cliente")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Digite o CPF do cliente")]
        public string CPF { get; set; }
        [Required(ErrorMessage = "Digite a data de nascimento")]
        public DateTime DataNascimento { get; set; }
    }
}
