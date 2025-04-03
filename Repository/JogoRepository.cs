using ProjetoDeJogos.Context;
using ProjetoDeJogos.Domains;
using ProjetoDeJogos.Interfaces;

namespace ProjetoDeJogos.Repository
{
    public class JogoRepository : IJogoRepository
    {

        //Herdar da interface:
        //Implementar os metodos da interface
        //Criar a variavel que puxa informacoes do CONTEXT
        private readonly ProjetoJogosContext _context;

        public JogoRepository(ProjetoJogosContext context)
        {
            _context = context;
        }


        public void Atualizar(Guid JogoID, Jogo jogoAtualizado)
        {
            throw new NotImplementedException();
        }


        public void Cadastrar(Jogo jogoNovo)
        {
            try
            {
                jogoNovo.JogoID = Guid.NewGuid();

                _context.Jogo.Add(jogoNovo);

                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }


        public void Deletar(Guid JogoID)
        {
            throw new NotImplementedException();
        }


        public List<Jogo> Listar()
        {
            try
            {
                return _context.Jogo.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
