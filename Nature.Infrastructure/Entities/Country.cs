#nullable disable

using Nature.Infrastructure.Entities.Interfaces;

namespace Nature.Infrastructure.Entities
{
    public sealed class Country : IEntityWithId
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
    }
}