using SistemaLocacao.Models;
using System.Collections.Generic;

namespace SistemaLocacao.Repositorio
{
    public interface IUsuarioRepositorio
    {
        List<UsuarioModel> BucarTodos();
        UsuarioModel ListarPorId(int id);
        UsuarioModel Adicionar(UsuarioModel usuario);
        UsuarioModel Atualizar(UsuarioModel usuario);
        bool Apagar(int id);
    }
}
