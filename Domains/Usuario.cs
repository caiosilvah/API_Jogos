using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace ProjetoDeJogos.Domains
{
    [Table("Usuario")]
    [Index(nameof(Nickname), IsUnique = true)]
    public class Usuario
    {
        [Key]
        public Guid UsuarioID { get; set; }

        [Column(TypeName = "VARCHAR(80)")]
        [Required(ErrorMessage = "O Nome do usuário é obrigatório!")]
        public string? Nome { get; set; }


        [Column(TypeName = "VARCHAR(40)")]
        [Required(ErrorMessage = "O Nome Nickname é obrigatório!")]
        public string? Nickname  { get; set; }

        public Guid? JogoFavorito { get; set; }
        [ForeignKey("JogoFavorito")]

        public Jogo? Jogo { get; set; }
    }
}
