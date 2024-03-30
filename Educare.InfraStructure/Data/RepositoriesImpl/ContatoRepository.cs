using Reluco.ReComex.Domain.Entities.Escola;
using Reluco.Siscomex.Application.Data;

namespace Educare.InfraStructure.Data.RepositoriesImpl
{
    public class ContatoRepository : BaseRepository<Contato>
    {
        public ContatoRepository(EscolaDbContext _dbContext) : base(_dbContext)
        {
        }
    }
}
