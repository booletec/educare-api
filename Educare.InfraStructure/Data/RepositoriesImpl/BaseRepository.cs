using Educare.Core.Abstractions;
using Microsoft.EntityFrameworkCore;
using Reluco.Siscomex.Application.Data;

namespace Educare.InfraStructure.Data.RepositoriesImpl
{
    public class BaseRepository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {
        protected readonly EscolaDbContext dbContext;
        protected DbSet<TEntity> entities;

        public BaseRepository(EscolaDbContext _dbContext)
        {
            dbContext = _dbContext;
            entities = dbContext.Set<TEntity>();
        }


        public async Task<TEntity> DeleteAsync(TEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            var returnedEntity = entities.Remove(entity);
            await dbContext.SaveChangesAsync();

            return await Task.FromResult(returnedEntity.Entity);
        }

        public virtual async Task<IQueryable<TEntity>> GetAllAsync() =>
            await Task.FromResult(entities.AsQueryable());

        public virtual async Task<TEntity> GetByIdAsync(int Id) =>
            await entities.FirstOrDefaultAsync(x => x.Id == Id);

        public async Task<TEntity> SaveAsync(TEntity entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");

            var returnedEntity = await entities.AddAsync(entity);
            await dbContext.SaveChangesAsync();

            return returnedEntity.Entity;
        }

        public async Task<TEntity> UpdateAsync(TEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            var returnedEntity = entities.Update(entity);
            await dbContext.SaveChangesAsync();

            return await Task.FromResult(returnedEntity.Entity);
        }
    }
}
