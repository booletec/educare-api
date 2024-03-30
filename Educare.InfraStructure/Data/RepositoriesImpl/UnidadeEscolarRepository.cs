using Reluco.ReComex.Domain.Entities.Escola;
using Reluco.Siscomex.Application.Data;

namespace Educare.InfraStructure.Data.RepositoriesImpl
{
    public class UnidadeEscolarRepository : BaseRepository<UnidadeEscolar>
    {
        public UnidadeEscolarRepository(EscolaDbContext _dbContext) : base(_dbContext)
        {
        }
    }
}
