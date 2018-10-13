using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Exemplo.Models
{
    public class Aluno
    {
        [Key]
        public int IDAluno { get; set; }

        [DisplayName("Professor")]
        public int IDProfessor { get; set; }

        [DisplayName("Nome do Aluno")]
        [Required(ErrorMessage = "O nome é obrigatório")]
        [MaxLength(20), MinLength(5)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O e-mail é obrigatório")]
        [StringLength(250)]
        public string Email { get; set; }

        [Range(1980,2020, ErrorMessage = "O ano deverá ser entre 1980 e 2020")]
        public int Ano { get; set; }

        public bool Aprovado { get; set; }

        [DisplayName("Inscrição")]
        public DateTime Inscricao { get; set; }

        //lazy loading = add virtual
        public virtual Professor Professor { get; set; }
    }
}