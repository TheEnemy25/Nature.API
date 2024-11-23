#nullable disable

using Nature.Infrastructure.Entities.Interfaces;

namespace Nature.Infrastructure.Entities
{
    public sealed class Plant : IEntityWithId
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
        public string Species { get; set; }
        public string Description { get; set; }

        // Relationships
        public ICollection<Habitat> Habitats { get; set; }
        public ICollection<PlantThreat> Threats { get; set; }
        public ICollection<PlantSafekeeping> Safekeepings { get; set; }
    }
}
