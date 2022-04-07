using System;
using System.ComponentModel.DataAnnotations;

namespace SistemaLocacao.Models
{
    public class FilmeModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Digite o título do filme")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "Digite a classificação indicativa do filme")]
        public int ClassificacaoIndicativa { get; set; }
        [Required(ErrorMessage = "Digite a data de nascimento")]
        public DateTime Lancamento { get; set; }
    }
}
