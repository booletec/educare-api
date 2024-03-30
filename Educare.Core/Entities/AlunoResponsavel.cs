using System.Collections.Generic;

namespace Educare.Core.School.Entities
{
    public class AlunoResponsavel : BaseEntity
    {
        public int AlunoId { get; set; }
        public Aluno Aluno { get; set; }
        public int ResponsavelId { get; set; }
        public Responsavel Responsavel { get; set; }
       
    }
}
