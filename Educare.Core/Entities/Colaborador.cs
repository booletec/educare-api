using Reluco.NewSchool.Domain.Entities.Escola;
using System.Collections.Generic;

namespace Educare.Core.School.Entities
{
    public class Colaborador : Pessoa
    {

        public Colaborador()
        {
            DiariosBordo = new HashSet<DiarioBordo>();
            Assiduidades = new HashSet<Assiduidade>();
        }

        public int? CargoId { get; set; }
        public Cargo Cargo { get; set; }

        public int? TurmaId { get; set; }
        public Turma Turma { get; set; }

        public ICollection<DiarioBordo> DiariosBordo { get; set; }
        public ICollection<Assiduidade> Assiduidades { get; set; }

    }


}
