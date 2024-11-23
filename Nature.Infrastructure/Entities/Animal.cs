#nullable disable

using Nature.Infrastructure.Entities.Interfaces;

namespace Nature.Infrastructure.Entities
{
    public sealed class Animal : IEntityWithId
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
        public string Species { get; set; }
        public string Description { get; set; }
        public string Behavior { get; set; }

        public ICollection<Habitat> Habitats { get; set; }
        public ICollection<AnimalSafekeeping> Safekeepings { get; set; }
        public ICollection<AnimalThreat> Threats { get; set; }
    }
}
