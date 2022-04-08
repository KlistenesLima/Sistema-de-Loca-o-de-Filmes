using System;
using System.ComponentModel.DataAnnotations;

namespace SistemaLocacao.Models
{
    public class LocacaoModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Digite o nome do cliente")]
        public string Cliente { get; set; }
        [Required(ErrorMessage = "Digite o título do filme")]
        public string Filme { get; set; }
        [Required(ErrorMessage = "Digite a data de locação")]
        public DateTime DataLocacao { get; set; }
        [Required(ErrorMessage = "Digite a data de devolução")]
        public DateTime DataDevolucao { get; set; }
    }
}
