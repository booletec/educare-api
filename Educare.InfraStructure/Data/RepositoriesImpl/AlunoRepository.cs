using Educare.Core.School.Entities;

namespace Educare.InfraStructure.Data.RepositoriesImpl
{
    public class AlunoRepository : BaseRepository<Aluno>
    {
        public AlunoRepository(EscolaDbContext _dbContext) : base(_dbContext)
        {
        }

        public override async Task<IQueryable<Aluno>> GetAllAsync()
        {
            var retval =  entities
                .Include(x => x.Contrato)
                .Include(x => x.Contatos)
                .Include(x => x.Enderecos)
                .Include(x => x.Turma)
                .Include(x => x.Responsaveis)
                    .ThenInclude(x => x.Responsavel)
                    .ThenInclude(x => x.Enderecos)
                .Include(x => x.Responsaveis)
                    .ThenInclude(x => x.Responsavel)
                    .ThenInclude(x => x.Contatos)
                   
                .Include(x => x.Turma).AsQueryable();

            return await Task.FromResult(retval);
           
        }

        public override async Task<Aluno> GetByIdAsync(int Id)
        {
           return await entities.Include(x => x.Contrato)
                .Include(x => x.Contatos)
                .Include(x => x.Enderecos)
                .Include(x => x.Turma)
                .Include(x => x.Responsaveis)
                    .ThenInclude(x => x.Responsavel)
                    .ThenInclude(x => x.Enderecos)
                .Include(x => x.Responsaveis)
                    .ThenInclude(x => x.Responsavel)
                    .ThenInclude(x => x.Contatos)

                .Include(x => x.Turma).Where(x => x.Id == Id).FirstOrDefaultAsync();

            
        }
    }
}
