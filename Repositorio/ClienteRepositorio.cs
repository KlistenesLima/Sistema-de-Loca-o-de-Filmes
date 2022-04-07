﻿using SistemaLocacao.Data;
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
            ClienteModel contatoDB = ListarPorId(cliente.Id);

            if (contatoDB == null) throw new System.Exception("Houve um erro na atualização do contato!");

            contatoDB.Nome = cliente.Nome;
            contatoDB.CPF = cliente.CPF;
            contatoDB.DataNascimento = cliente.DataNascimento;

            _context.Clientes.Update(contatoDB);
            _context.SaveChanges();

            return contatoDB;

        }

        public bool Apagar(int id)
        {
            ClienteModel contatoDB = ListarPorId(id);

            if (contatoDB == null) throw new System.Exception("Houve um erro na deleção do contato!");

            _context.Clientes.Remove(contatoDB);
            _context.SaveChanges();

            return true;
        }
    }
}
