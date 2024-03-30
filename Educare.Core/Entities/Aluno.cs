using Reluco.NewSchool.Domain.Entities.Escola;

namespace Educare.Core.School.Entities
{
    public class Aluno : Pessoa
    {

        public Aluno()
        {
            Responsaveis = new HashSet<AlunoResponsavel>();
            DiariosBordo = new HashSet<DiarioBordo>();
            Assiduidades = new HashSet<Assiduidade>();
        }

        public string Matricula { get; set; }
        
       
        public ICollection<AlunoResponsavel> Responsaveis { get; set; }
        public ICollection<DiarioBordo> DiariosBordo { get; set; }


        public int? ContratoId { get; set; }
        public Contrato Contrato { get; set; }

        public int? TurmaId { get; set; }
        public Turma Turma { get; set; }

        public ICollection<Assiduidade> Assiduidades { get; set; }

    }
}
