using ProjetoDeJogos.Domains;

namespace ProjetoDeJogos.Interfaces
{
    public interface IUsuarioRepository
    {
        void Cadastrar(Usuario usuarioNovo);
        List<Usuario> Listar();
        void Deletar(Guid UsuarioID);
        void Atualizar(Guid UsuarioID, Usuario usuarioAtualizado);
    }
}
