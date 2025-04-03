using ProjetoDeJogos.Domains;

namespace ProjetoDeJogos.Interfaces
{
    public interface IJogoRepository
    {
        void Cadastrar(Jogo jogoNovo);
        List<Jogo> Listar();
        void Deletar(Guid JogoID);
        void Atualizar (Guid JogoID, Jogo jogoAtualizado);

    }
}
