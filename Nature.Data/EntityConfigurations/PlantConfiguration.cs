using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nature.Infrastructure.Entities;

namespace Nature.Data.EntityConfigurations
{
    public class PlantConfiguration : IEntityTypeConfiguration<Plant>
    {
        public void Configure(EntityTypeBuilder<Plant> builder)
        {
            builder.ToTable("Plant");

            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).ValueGeneratedOnAdd();

            builder.Property(p => p.Name).IsRequired().HasMaxLength(100);
            builder.Property(p => p.Species).HasMaxLength(100);
            builder.Property(p => p.Description).HasMaxLength(255);
            builder.Property(p => p.PhotoUrl).HasMaxLength(255);
            builder.Property(p => p.AudioUrl).HasMaxLength(255);

            builder.HasOne(p => p.Habitat)
                   .WithMany(h => h.Plants)
                   .HasForeignKey(p => p.HabitatId)
                   .OnDelete(DeleteBehavior.Cascade);



            builder.HasMany(p => p.Threats)
                   .WithMany(t => t.Plants);

            builder.HasMany(p => p.ConservationEfforts)
                   .WithOne(e => e.Plant)
                   .HasForeignKey(e => e.PlantId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
