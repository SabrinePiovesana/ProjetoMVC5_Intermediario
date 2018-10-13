using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Exemplo.Models
{
    public class Professor
    {
        [Key, Column(Order =0)]
        public int IDProfessor { get; set; }

        [DisplayName("Professor")]
        [Required(ErrorMessage ="Digite o nome do professor."), Column(Order=1)]
        [MinLength(8, ErrorMessage ="O tamanho mínimo do nome são 8 caracteres.")]
        public string Nome { get; set; }

        public string Telefone { get; set; }

        [DisplayName("Salário")]
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode =true, NullDisplayText = "Sem remuneração")]
        [Range(1200,25000, ErrorMessage ="O salário deverá ser entre 1200 e 25000")]
        public decimal? Salario { get; set; }    
        
        [Display(Name ="Twitter/Blog")]
        [Column("ContatoDigital", Order =5)]
        public string TwitterBlog { get; set; }

        [DisplayName("Matéria")]
        public string Materia { get; set; }

        public bool Disponivel { get; set; }

        [DisplayName("Admissão")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? Admissao { get; set; }

        public List<Aluno> Alunos { get; set; }

        public List<Topico> Topicos { get; set; }
    }
}