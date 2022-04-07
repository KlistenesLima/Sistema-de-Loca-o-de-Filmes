using SistemaLocacao.Data;
using SistemaLocacao.Models;
using System.Collections.Generic;
using System.Linq;

namespace SistemaLocacao.Repositorio
{
    public class FilmeRepositorio : IFilmeRepositorio
    {
        private readonly BancoContext _context;

        public FilmeRepositorio(BancoContext bancoContext)
        {
                this._context = bancoContext;
        }

        public FilmeModel ListarPorId(int id)
        {
            return _context.Filmes.FirstOrDefault(x => x.Id == id);
        }

        public List<FilmeModel> BucarTodos()
        {
            return _context.Filmes.ToList();
        }

        public FilmeModel Adicionar(FilmeModel filme)
        {
            // gravar no banco de dados
            _context.Filmes.Add(filme);
            _context.SaveChanges();

            return filme;
        }

        public FilmeModel Atualizar(FilmeModel filme)
        {
            FilmeModel filmeDB = ListarPorId(filme.Id);

            if (filmeDB == null) throw new System.Exception("Houve um erro na atualização do contato!");

            filmeDB.Titulo = filme.Titulo;
            filmeDB.ClassificacaoIndicativa = filme.ClassificacaoIndicativa;
            filmeDB.Lancamento = filme.Lancamento;

            _context.Filmes.Update(filmeDB);
            _context.SaveChanges();

            return filmeDB;

        }

        public bool Apagar(int id)
        {
            FilmeModel filmeDB = ListarPorId(id);

            if (filmeDB == null) throw new System.Exception("Houve um erro na deleção do contato!");

            _context.Filmes.Remove(filmeDB);
            _context.SaveChanges();

            return true;
        }
    }
}
