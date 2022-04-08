using SistemaLocacao.Models;
using System.Collections.Generic;

namespace SistemaLocacao.Repositorio
{
    public interface ILocacaoRepositorio
    {
        List<LocacaoModel> BucarTodos();
        LocacaoModel ListarPorId(int id);
        LocacaoModel Adicionar(LocacaoModel locacao);
        LocacaoModel Atualizar(LocacaoModel locacao);
        bool Apagar(int id);
    }
}
