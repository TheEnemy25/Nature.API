#nullable disable

using Nature.Infrastructure.Entities.Interfaces;
using System.Text.Json.Serialization;

namespace Nature.Infrastructure.Entities
{
    public sealed class Plant : IEntityWithId
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
        public string Species { get; set; }
        public string Description { get; set; }
        public string PhotoUrl { get; set; }

        // Relationships
        [JsonIgnore]
        public ICollection<Habitat> Habitats { get; set; }
        public ICollection<PlantThreat> Threats { get; set; }
        public ICollection<PlantSafekeeping> Safekeepings { get; set; }
    }
}
