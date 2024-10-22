using Nature.Infrastructure.Entities.Interfaces;

namespace Nature.Infrastructure.Entities
{
    public class ConservationEffort : IEntityWithId
    {
        public Guid Id { get; set; }
        public Guid PlantId { get; set; }
        public Guid AnimalId { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }

        public Plant Plant { get; set; }
        public Animal Animal { get; set; }
    }
}
