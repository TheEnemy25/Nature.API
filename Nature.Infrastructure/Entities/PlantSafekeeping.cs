#nullable disable

using Nature.Infrastructure.Entities.Interfaces;

namespace Nature.Infrastructure.Entities
{
    public sealed class PlantSafekeeping : IEntityWithId
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }

        public Guid PlantId { get; set; }

        public Plant Plant { get; set; }
    }
}