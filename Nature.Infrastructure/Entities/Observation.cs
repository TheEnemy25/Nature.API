using Nature.Infrastructure.Entities.Interfaces;

namespace Nature.Infrastructure.Entities
{
    public class Observation : IEntityWithId
    {
        public Guid Id { get; set; }

        public Guid PlantId { get; set; }
        public Guid AnimalId { get; set; }

        public DateTime Date { get; set; }
        public string Notes { get; set; }

        public Plant Plant { get; set; }
        public Animal Animal { get; set; }
    }
}
//public Guid UserId { get; set; }

//public User User { get; set; }
