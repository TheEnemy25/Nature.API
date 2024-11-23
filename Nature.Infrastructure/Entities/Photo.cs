using Nature.Infrastructure.Entities.Interfaces;

namespace Nature.Infrastructure.Entities
{
    public sealed class Photo : IEntityWithId
    {
        public Guid Id { get; set; }

        public byte[] PhotoBytes { get; set; } = null!;
        public bool IsPreview { get; set; }
        //TODO: Add a DB constraint to allow just one value
        public Guid? PlantId { get; set; } = null;
        public Guid? AnimalId { get; set; } = null;

        public Plant? Plant { get; set; } = null;
        public Animal? Animal { get; set; } = null;
    }
}