using System.Data.Entity;

namespace Exemplo.Models
{
    public class BancoContexto: DbContext
    {
        public BancoContexto()
            :base("BancoContexto")
        {

        }

        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Professor> Professores { get; set; }
        public DbSet<Topico> Topicos { get; set; }
    }
}