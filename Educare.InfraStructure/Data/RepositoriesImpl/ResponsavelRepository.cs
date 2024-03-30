using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Reluco.ReComex.Domain.Entities.Escola;
using Reluco.Siscomex.Application.Data;

namespace Educare.InfraStructure.Data.RepositoriesImpl
{
    public class ResponsavelRepository : BaseRepository<Responsavel>
    {
        public ResponsavelRepository(EscolaDbContext _dbContext) : base(_dbContext)
        {
        }

        public override Task<Responsavel> GetByIdAsync(int Id)
        {
            return entities
                .Include(x => x.Enderecos)
                .Include(x => x.Contatos)
                .FirstOrDefaultAsync(x => x.Id == Id);
        }
    }
}
