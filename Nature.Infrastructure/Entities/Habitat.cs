#nullable disable

using Nature.Infrastructure.Entities.Interfaces;
using Nature.Infrastructure.Enums;
using System.Text.Json.Serialization;

namespace Nature.Infrastructure.Entities
{
    public sealed class Habitat : IEntityWithId
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
        public string Location { get; set; }
        public EHabitatType Type { get; set; }  // e.g., Forest, Wetland

        public Guid ReserveAreaId { get; set; }

        //TODO: Nav props
        public ReserveArea ReserveArea { get; set; }
        [JsonIgnore]
        public ICollection<Animal> Animals { get; set; }
        [JsonIgnore]
        public ICollection<Plant> Plants { get; set; }
    }
}
