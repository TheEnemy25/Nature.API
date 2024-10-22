using Nature.Infrastructure.Entities.Interfaces;

namespace Nature.Infrastructure.Entities
{
    public class Threat : IEntityWithId
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<Plant> Plants { get; set; }
        public ICollection<Animal> Animals { get; set; }
    }
}
