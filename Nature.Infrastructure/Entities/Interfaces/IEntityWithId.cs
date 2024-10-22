namespace Nature.Infrastructure.Entities.Interfaces
{
    public interface IEntityWithId : IEntity
    {
        public Guid Id { get; set; }
    }
}
