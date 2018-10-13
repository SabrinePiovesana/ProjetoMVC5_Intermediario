using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Exemplo.Models
{
    public class Topico
    {
        [Key]
        public int IDTopico { get; set; }

        [DisplayName("Professor")]
        public int IDProfessor { get; set; }

        [DisplayName("Descrição")]
        [Required(ErrorMessage = "Digite o tópico")]
        [MaxLength(100), MinLength(5)]
        public string Descricao { get; set; }

        public virtual Professor Professor { get; set; }
    }
}