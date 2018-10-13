using System.Collections.Generic;
using System.Data.Entity;

namespace Exemplo.Models
{
    public class InicializarBanco : DropCreateDatabaseAlways<BancoContexto>
    {
        protected override void Seed(BancoContexto context)
        {
            //criar alguns dados no banco
            new List<Professor> {
                new Professor {
                    Nome= "Sabrine Piovesana",
                    Materia = "ASP.NET MVC",
                    Salario = 4000,
                    Telefone= "54 34531330",
                    TwitterBlog= "",
                    Disponivel= true,
                    Admissao= new System.DateTime(2012,05,01),
                        Alunos= new List<Aluno>()
                        {
                            new Aluno
                            {
                                Nome= "Bruno",
                                Email="bruno@msn.com",
                                Aprovado=false,
                                Ano=2011,
                                Inscricao= new System.DateTime(2011,8,12)
                            },

                            new Aluno
                             {
                                Nome= "Rafael",
                                Email="rafael@msn.com",
                                Aprovado=false,
                                Ano=2011,
                                Inscricao= new System.DateTime(2011,7,12),
                            }
                        },

                        Topicos = new List<Topico>()
                        {
                            new Topico {Descricao= "Tópico 1"},
                            new Topico {Descricao= "Tópico 2"}
                        }
                    }
            }.ForEach(x=> context.Professores.Add(x));

            base.Seed(context);
        }
    }
}