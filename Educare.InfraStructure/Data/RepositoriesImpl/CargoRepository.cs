using Reluco.ReComex.Domain.Entities.Escola;
using Reluco.Siscomex.Application.Data;

namespace Educare.InfraStructure.Data.RepositoriesImpl
{
    public class CargoRepository : BaseRepository<Cargo>
    {
        public CargoRepository(EscolaDbContext _dbContext) : base(_dbContext)
        {
        }
    }
}
