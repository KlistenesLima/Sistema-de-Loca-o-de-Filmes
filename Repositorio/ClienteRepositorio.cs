using SistemaLocacao.Data;
using SistemaLocacao.Models;
using System.Collections.Generic;
using System.Linq;

namespace SistemaLocacao.Repositorio
{
    public class ClienteRepositorio : IClienteRepositorio
    {
        private readonly BancoContext _context;

        public ClienteRepositorio(BancoContext bancoContext)
        {
                this._context = bancoContext;
        }

        public ClienteModel ListarPorId(int id)
        {
            return _context.Clientes.FirstOrDefault(x => x.Id == id);
        }

        public List<ClienteModel> BucarTodos()
        {
            return _context.Clientes.ToList();
        }

        public ClienteModel Adicionar(ClienteModel cliente)
        {
            // gravar no banco de dados
            _context.Clientes.Add(cliente);
            _context.SaveChanges();

            return cliente;
        }

        public ClienteModel Atualizar(ClienteModel cliente)
        {
            ClienteModel clienteDB = ListarPorId(cliente.Id);

            if (clienteDB == null) throw new System.Exception("Houve um erro na atualização do contato!");

            clienteDB.Nome = cliente.Nome;
            clienteDB.CPF = cliente.CPF;
            clienteDB.DataNascimento = cliente.DataNascimento;

            _context.Clientes.Update(clienteDB);
            _context.SaveChanges();

            return clienteDB;

        }

        public bool Apagar(int id)
        {
            ClienteModel clienteDB = ListarPorId(id);

            if (clienteDB == null) throw new System.Exception("Houve um erro na deleção do contato!");

            _context.Clientes.Remove(clienteDB);
            _context.SaveChanges();

            return true;
        }
    }
}
