using Reluco.NewSchool.Common.Contracts.Enumeradores;
using Reluco.NewSchool.Domain.Entities.Escola;
using System.Collections.Generic;

namespace Educare.Core.School.Entities
{
    public class Responsavel : Pessoa
    {

        public ICollection<AlunoResponsavel> Alunos { get; set; }
        public GrauParentesco GrauParentesco { get; set; }
       
    }

   
}
