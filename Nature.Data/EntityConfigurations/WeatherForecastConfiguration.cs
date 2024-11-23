using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Nature.Infrastructure.Entities
{
    public class WeatherForecastConfiguration : IEntityTypeConfiguration<WeatherForecast>
    {
        public void Configure(EntityTypeBuilder<WeatherForecast> builder)
        {
            // Configure the primary key
            builder.HasKey(wf => wf.Id);

            // Configure the properties
            builder.Property(wf => wf.Timestamp)
                .IsRequired(); // Ensure Timestamp is required

            builder.Property(wf => wf.TemperatureC)
                .IsRequired(); // Ensure TemperatureC is required

            builder.Property(wf => wf.TemperatureF)
                .IsRequired(); // Ensure TemperatureF is required

            builder.Property(wf => wf.AtmospherePressure)
                .IsRequired(); // Ensure AtmospherePressure is required

            builder.Property(wf => wf.RainfallChance)
                .IsRequired(); // Ensure RainfallChance is required

            builder.Property(wf => wf.WindSpeed)
                .IsRequired(); // Ensure WindSpeed is required

            builder.Property(wf => wf.ReserveId)
                .IsRequired(); // Ensure ReserveId is required

            // Optional: Table name
            builder.ToTable("WeatherForecasts");
        }
    }
}
