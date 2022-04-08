using System;
using System.ComponentModel.DataAnnotations;

namespace SistemaLocacao.Models
{
    public class LocacaoModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Digite o nome do cliente")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Digite o CPF do cliente")]
        public string CPF { get; set; }
        [Required(ErrorMessage = "Digite a data de locação")]
        public DateTime DataLocacao { get; set; }
        [Required(ErrorMessage = "Digite a data de devolução")]
        public DateTime DataDevolucao { get; set; }
    }
}
