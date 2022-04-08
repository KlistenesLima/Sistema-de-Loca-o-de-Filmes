using SistemaLocacao.Data;
using SistemaLocacao.Models;
using System.Collections.Generic;
using System.Linq;

namespace SistemaLocacao.Repositorio
{
    public class LocacaoRepositorio : ILocacaoRepositorio
    {
        private readonly BancoContext _context;

        public LocacaoRepositorio(BancoContext bancoContext)
        {
                this._context = bancoContext;
        }

        public LocacaoModel ListarPorId(int id)
        {
            return _context.Locacoes.FirstOrDefault(x => x.Id == id);
        }

        public List<LocacaoModel> BucarTodos()
        {
            return _context.Locacoes.ToList();
        }

        public LocacaoModel Adicionar(LocacaoModel locacao)
        {
            // gravar no banco de dados
            _context.Locacoes.Add(locacao);
            _context.SaveChanges();

            return locacao;
        }

        public LocacaoModel Atualizar(LocacaoModel locacao)
        {
            LocacaoModel locacaoDB = ListarPorId(locacao.Id);

            if (locacaoDB == null) throw new System.Exception("Houve um erro na atualização do contato!");

            locacaoDB.Cliente = locacao.Cliente;
            locacaoDB.Filme = locacao.Filme;
            locacaoDB.DataLocacao = locacao.DataLocacao;
            locacaoDB.DataDevolucao = locacao.DataDevolucao;

            _context.Locacoes.Update(locacaoDB);
            _context.SaveChanges();

            return locacaoDB;

        }

        public bool Apagar(int id)
        {
            LocacaoModel locacaoDB = ListarPorId(id);

            if (locacaoDB == null) throw new System.Exception("Houve um erro na deleção do contato!");

            _context.Locacoes.Remove(locacaoDB);
            _context.SaveChanges();

            return true;
        }
    }
}
