#nullable disable

using Nature.Infrastructure.Entities.Interfaces;

namespace Nature.Infrastructure.Entities
{
    public sealed class WeatherForecast : IEntityWithId
    {
        public Guid Id { get; set; }

        public DateTime Timestamp { get; set; }
        public float TemperatureC { get; set; }
        public float TemperatureF { get; set; }
        public int AtmospherePressure { get; set; }
        public int RainfallChance { get; set; }
        public float WindSpeed { get; set; }

        public Guid ReserveId { get; set; }

        public Reserve Reserve { get; set; }
    }
}
