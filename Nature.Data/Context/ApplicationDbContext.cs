using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Nature.Data.Entities;
using Nature.Data.EntityConfigurations;

namespace Nature.Data.Context
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Animal> Animals { get; set; }
        public DbSet<Plant> Plants { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AnimalConfiguration());
            modelBuilder.ApplyConfiguration(new PlantConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
