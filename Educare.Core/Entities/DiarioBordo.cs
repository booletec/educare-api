using Reluco.ReComex.Domain.Entities;
using Educare.Core.School.Entities;

namespace Reluco.NewSchool.Domain.Entities.Escola
{
    public class DiarioBordo : BaseEntity
    {
        
        public string Descricao { get; set; }

        public int CriadorPorId { get; set; }
        public Colaborador CriadoPor { get; set; }

        public int AlunoId { get; set; }
        public Aluno Aluno { get; set; }
        
    }
}
