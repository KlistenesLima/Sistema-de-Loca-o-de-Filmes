using System;
using System.Collections.Generic;

namespace SistemaLocacao.Models
{
    public class ClienteLocacaoFilme
    {
        public ClienteModel Cliente { get; set; }
        public FilmeModel Filme { get; set; }
        public LocacaoModel Locacao { get; set; }
    }
}
