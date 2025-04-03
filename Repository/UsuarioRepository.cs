using ProjetoDeJogos.Context;
using ProjetoDeJogos.Domains;
using ProjetoDeJogos.Interfaces;

namespace ProjetoDeJogos.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {

        private readonly ProjetoJogosContext _context;

        public UsuarioRepository(ProjetoJogosContext context)
        {
            _context = context;
        }

        public void Atualizar(Guid UsuarioID, Usuario usuarioAtualizado)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(Usuario usuarioNovo)
        {
            throw new NotImplementedException();
        }

        public void Deletar(Guid UsuarioID)
        {
            throw new NotImplementedException();
        }

        public List<Usuario> Listar()
        {
            throw new NotImplementedException();
        }
    }
}
