#nullable disable

using Nature.Infrastructure.Entities.Interfaces;

namespace Nature.Infrastructure.Entities
{
    public sealed class Reserve : IEntityWithId
    {
        public Guid Id { get; set; }

        public Guid Name { get; set; }

        public Guid CityId { get; set; }

        public City City { get; set; }
        public ICollection<MapPoint> MapPoints { get; set; }
    }
}