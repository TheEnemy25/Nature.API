using Nature.Infrastructure.Entities.Interfaces;

namespace Nature.Infrastructure.Entities
{
    public sealed class MapPoint : IEntityWithId
    {
        public Guid Id { get; set; }

        public double Latitude { get; set; }
        public double Longtitude { get; set; }
        //TODO: Add a constraint to allow a single value
        public Guid? ReserveAreaId { get; set; } = null;
        public Guid? ReserveId { get; set; } = null;

        public Reserve? Reserve { get; set; } = null;
        public ReserveArea? ReserveArea { get; set; } = null;
    }
}
