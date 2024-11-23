#nullable disable

using Nature.Infrastructure.Entities.Interfaces;

namespace Nature.Infrastructure.Entities
{
    public sealed class AnimalThreat : IEntityWithId
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }

        public Guid AnimalId { get; set; }

        public Animal Animal { get; set; }
    }
}