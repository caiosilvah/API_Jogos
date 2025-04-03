using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

// namespace -> Caminho em que a clsse jogo esta
namespace ProjetoDeJogos.Domains
{
    [Table("Jogo")]
    // O Index faz com que o NomeDoJogo NAO se repita
    [Index(nameof(NomeDoJogo), IsUnique = true)]
    // Public class -> cria uma classe publica
    public class Jogo
    {
        // Preencher os atributos
        [Key] 
        public Guid JogoID { get; set; }

        [Column(TypeName = "VARCHAR(50)")]
        // O required faz com que seja obrigatorio preencher o campo NomeDoJogo
        [Required(ErrorMessage = "O nome do jogo e obrigatorio!")]
        public string? NomeDoJogo {  get; set; }

        [Column(TypeName = "VARCHAR(50)")]
        public string? Plataforma { get; set; }
    }
}
