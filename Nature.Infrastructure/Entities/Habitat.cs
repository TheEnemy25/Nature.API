using Nature.Infrastructure.Entities.Interfaces;

namespace Nature.Infrastructure.Entities
{
    public class Habitat : IEntityWithId
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
        public string Location { get; set; }
        public string Type { get; set; }  // e.g., Forest, Wetland


        public ICollection<Plant> Plants { get; set; }
        public ICollection<Animal> Animals { get; set; }
    }
}
