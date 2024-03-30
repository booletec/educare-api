using Microsoft.EntityFrameworkCore;
using Reluco.NewSchool.Domain.Entities.Escola;
using Reluco.ReComex.Domain.Entities.Escola;
using Reluco.Siscomex.Application.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Educare.InfraStructure.Data.RepositoriesImpl
{
    public class EventoRepository : BaseRepository<Evento>
    {
        public EventoRepository(EscolaDbContext _dbContext) : base(_dbContext)
        {
        }

        //public override async Task<IQueryable<DiarioBordo>> GetAllAsync()
        //{
        //    var retval = entities
        //        .Include(x => x.Aluno)
        //        .Include(x => x.CriadoPor).AsQueryable();

        //    return await Task.FromResult(retval);

        //}


        //public override async Task<DiarioBordo> GetByIdAsync(int Id)
        //{
        //    return await entities
        //         .Include(x => x.Aluno)
        //        .Include(x => x.CriadoPor).FirstOrDefaultAsync(x => x.Id == Id);


        //}
    }
}
