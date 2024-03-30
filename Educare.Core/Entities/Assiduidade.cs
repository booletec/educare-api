using Educare.Core.Abstractions;
using Educare.Core.School.Entities;

namespace Reluco.NewSchool.Domain.Entities.Escola
{
    public class Assiduidade : BaseEntity
    {
        public int ColaboradorId { get; set; }
        public Colaborador Colaborador { get; set; }
        public int AlunoId { get; set; }
        public Aluno Aluno { get; set; }
        public int TurmaId { get; set; }
        public Turma Turma { get; set; }
        public DateTime DataRegistro { get; set; }
        public TipoAssiduidade TipoAssiduidade { get; set; }
        public string Observacao { get; set; }

    }
}
