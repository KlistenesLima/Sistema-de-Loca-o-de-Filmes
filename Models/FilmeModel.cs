using System;
using System.ComponentModel.DataAnnotations;

namespace SistemaLocacao.Models
{
    public class FilmeModel
    {
        public int Id { get; set; }
        [StringLength(200)]
        [Required(ErrorMessage = "Digite o título do filme")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "Digite a classificação indicativa do filme")]
        public int ClassificacaoIndicativa { get; set; }
        [Required(ErrorMessage = "Confirme se o filme é ou não um lançamento")]
        public bool Lancamento { get; set; }
    }
}
