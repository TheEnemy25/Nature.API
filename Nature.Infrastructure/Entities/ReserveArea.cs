#nullable disable

using Nature.Infrastructure.Entities.Interfaces;

namespace Nature.Infrastructure.Entities
{
    public sealed class ReserveArea : IEntityWithId
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public Guid ReserveId { get; set; }

        public Reserve Reserve { get; set; }
        public ICollection<Habitat> Habitats { get; set; }
        public ICollection<MapPoint> MapPoints { get; set; }
    }
}
