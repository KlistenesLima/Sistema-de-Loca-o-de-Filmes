using System;
using System.ComponentModel.DataAnnotations;

namespace SistemaLocacao.Models
{
    public class LocacaoModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Digite o Id do cliente")]
        public int Id_Cliente { get; set; }
        [Required(ErrorMessage = "Digite o Id do filme")]
        public int Id_Filme { get; set; }
        [Required(ErrorMessage = "Digite a data de locação")]
        public DateTime DataLocacao { get; set; }
        [Required(ErrorMessage = "Digite a data de devolução")]
        public DateTime DataDevolucao { get; set; }
    }
}
