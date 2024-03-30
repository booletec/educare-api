using Reluco.NewSchool.Domain.Entities.Escola;
using System.Collections.Generic;

namespace Educare.Core.School.Entities
{
    public class Turma : BaseEntity
    {

        public Turma()
        {
            Assiduidades = new HashSet<Assiduidade>();
        }

        public int AnoLetivo { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int Vagas { get; set; }
        public int? Turno { get; set; }
        /// <summary>
        /// infantil, fundamental, médio
        /// </summary>
        public int TipoEnsino { get; set; }

        public int Serie { get; set; }

        public int IdadeMinima { get; set; }
        public int IdadeMaxima { get; set; }
        public ICollection<Aluno> Alunos { get; set; }
        public ICollection<Colaborador> Professores { get; set; }
        public ICollection<Assiduidade> Assiduidades { get; set; }

    }
}
