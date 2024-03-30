using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Reluco.ReComex.Domain.Entities.Escola;
using Reluco.Siscomex.Application.Data;

namespace Educare.InfraStructure.Data.RepositoriesImpl
{
    public class TurmaRepository : BaseRepository<Turma>
    {
        public TurmaRepository(EscolaDbContext _dbContext) : base(_dbContext)
        {
        }

        public override async Task<IQueryable<Turma>> GetAllAsync()
        {
            return await Task.FromResult(entities.Include(x => x.Professores).Include(x => x.Alunos).AsQueryable());
        }

        public override Task<Turma> GetByIdAsync(int Id)
        {
            return entities
                .Include(x => x.Professores)
                .ThenInclude(x => x.Cargo)
                .Include(x => x.Alunos).FirstOrDefaultAsync(x => x.Id == Id);
        }
    }
}
