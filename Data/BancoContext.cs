using SistemaLocacao.Models;
using Microsoft.EntityFrameworkCore;

namespace SistemaLocacao.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {
        }

        public DbSet<ClienteModel> Clientes { get; set; }
        public DbSet<FilmeModel> Filmes { get; set; }
        public DbSet<LocacaoModel> Locacoes { get; set; }
    }
}
