namespace Educare.Core.Abstractions
{
    public interface IRepository<TEntity> : IReadRepository<TEntity>, IWriteRepository<TEntity>
        where TEntity : IEntity
    { }

    public interface IReadRepository<TEntity> where TEntity : IEntity
    {
        Task<IEnumerable<TEntity>> GetAllAsync(int page, int pageSize);
        Task<TEntity> GetByIdAsync(Guid Id);
    }

    public interface IWriteRepository<TEntity> where TEntity : IEntity
    {
        Task<TEntity> SaveAsync(TEntity entity);
        Task<TEntity> UpdateAsync(TEntity entity);
        Task<TEntity> DeleteAsync(Guid Id);
    }
}
