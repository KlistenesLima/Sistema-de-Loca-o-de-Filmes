using SistemaLocacao.Models;
using System.Collections.Generic;

namespace SistemaLocacao.Repositorio
{
    public interface IFilmeRepositorio
    {
        List<FilmeModel> BucarTodos();
        FilmeModel ListarPorId(int id);
        FilmeModel Adicionar(FilmeModel filme);
        FilmeModel Atualizar(FilmeModel filme);
        bool Apagar(int id);
    }
}
