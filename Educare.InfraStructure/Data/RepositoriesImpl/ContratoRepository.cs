using Reluco.ReComex.Domain.Entities.Escola;
using Reluco.Siscomex.Application.Data;

namespace Educare.InfraStructure.Data.RepositoriesImpl
{
    public class ContratoRepository : BaseRepository<Contrato>
    {
        public ContratoRepository(EscolaDbContext _dbContext) : base(_dbContext)
        {
        }
    }
}
