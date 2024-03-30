using Reluco.ReComex.Domain.Entities.Escola;
using Reluco.Siscomex.Application.Data;

namespace Educare.InfraStructure.Data.RepositoriesImpl
{
    public class ColaboradorRepository : BaseRepository<Colaborador>
    {
        public ColaboradorRepository(EscolaDbContext _dbContext) : base(_dbContext)
        {
        }
    }
}
