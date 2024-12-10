using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Nature.Data.EntityConfigurations;
using Nature.Infrastructure.Entities;

namespace Nature.Data.Context
{
    public class ApplicationDbContext : IdentityDbContext<AppUser, IdentityRole<Guid>, Guid>
    {
        public DbSet<Animal> Animals { get; set; }
        public DbSet<AnimalAudio> AnimalAudios { get; set; }
        public DbSet<AnimalSafekeeping> AnimalSafekeepings { get; set; }
        public DbSet<AnimalThreat> AnimalThreats { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Habitat> Habitats { get; set; }
        public DbSet<MapPoint> MapPoints { get; set; }
        public DbSet<Observation> Observations { get; set; }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<Plant> Plants { get; set; }
        public DbSet<PlantSafekeeping> PlantSafekeepings { get; set; }
        public DbSet<PlantThreat> PlantThreats { get; set; }
        public DbSet<Reserve> Reserves { get; set; }
        public DbSet<ReserveArea> ReserveAreas { get; set; }
        public DbSet<WeatherForecast> WeatherForecasts { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AnimalConfiguration());
            modelBuilder.ApplyConfiguration(new AnimalAudioConfiguration());
            modelBuilder.ApplyConfiguration(new AnimalSafekeepingConfiguration());
            modelBuilder.ApplyConfiguration(new AnimalThreatConfiguration());
            modelBuilder.ApplyConfiguration(new CityConfiguration());
            modelBuilder.ApplyConfiguration(new CountryConfiguration());
            modelBuilder.ApplyConfiguration(new HabitatConfiguration());
            modelBuilder.ApplyConfiguration(new MapPointConfiguration());
            modelBuilder.ApplyConfiguration(new ObservationConfiguration());
            modelBuilder.ApplyConfiguration(new PhotoConfiguration());
            modelBuilder.ApplyConfiguration(new PlantConfiguration());
            modelBuilder.ApplyConfiguration(new PlantSafekeepingConfiguration());
            modelBuilder.ApplyConfiguration(new PlantThreatConfiguration());
            modelBuilder.ApplyConfiguration(new ReserveAreaConfiguration());
            modelBuilder.ApplyConfiguration(new ReserveConfiguration());
            modelBuilder.ApplyConfiguration(new WeatherForecastConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
