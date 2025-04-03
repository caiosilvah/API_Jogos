using Microsoft.EntityFrameworkCore;
using ProjetoDeJogos.Domains;

namespace ProjetoDeJogos.Context
{
    public class ProjetoJogosContext : DbContext
    {
        // Metodo construtor tem o mesmo nome da classe:
        public ProjetoJogosContext(){}
        public ProjetoJogosContext(DbContextOptions<ProjetoJogosContext> options) : base(options)
        {
        }

        public DbSet<Jogo> Jogo { get; set; }
        public DbSet<Usuario> Usuario { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-5D5JI58\\SQLEXPRESS; Database=Jogos; User Id = sa; Pwd = Senai@134; TrustServerCertificate=true;");
            }
        }
    }
}
