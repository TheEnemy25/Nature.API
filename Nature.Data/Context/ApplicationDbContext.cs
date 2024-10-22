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
        public DbSet<Plant> Plants { get; set; }
        public DbSet<Habitat> Habitats { get; set; }
        public DbSet<Threat> Threats { get; set; }
        public DbSet<ConservationEffort> ConservationEfforts { get; set; }
        public DbSet<Observation> Observations { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AnimalConfiguration());
            modelBuilder.ApplyConfiguration(new PlantConfiguration());
            modelBuilder.ApplyConfiguration(new HabitatConfiguration());
            modelBuilder.ApplyConfiguration(new ThreatConfiguration());
            modelBuilder.ApplyConfiguration(new ConservationEffortConfiguration());
            modelBuilder.ApplyConfiguration(new ObservationConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
