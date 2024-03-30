namespace Educare.Core.Abstractions
{
    public abstract class BaseEntity : IEntity
    {
        public int Id { get; init; }
        public DateTime CreatedOn { get; init; } = DateTime.UtcNow;
        public DateTime ModifiedOn { get; init; } = DateTime.UtcNow;
        public bool Desabilitado { get; init; } = false;
    }
}
