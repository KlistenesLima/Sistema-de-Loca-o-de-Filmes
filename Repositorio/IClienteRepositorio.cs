using SistemaLocacao.Models;
using System.Collections.Generic;

namespace SistemaLocacao.Repositorio
{
    public interface IClienteRepositorio
    {
        List<ClienteModel> BucarTodos();
        ClienteModel ListarPorId(int id);
        ClienteModel Adicionar(ClienteModel cliente);
        ClienteModel Atualizar(ClienteModel cliente);
        bool Apagar(int id);
    }
}
