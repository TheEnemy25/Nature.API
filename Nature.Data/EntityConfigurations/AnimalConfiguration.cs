using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nature.Infrastructure.Entities;

namespace Nature.Data.EntityConfigurations
{
    public class AnimalConfiguration : IEntityTypeConfiguration<Animal>
    {
        public void Configure(EntityTypeBuilder<Animal> builder)
        {
            builder.ToTable("Animal");

            builder.HasKey(a => a.Id);
            builder.Property(a => a.Id).ValueGeneratedOnAdd();

            builder.Property(a => a.Name)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(a => a.Species)
                .HasMaxLength(100);

            builder.Property(a => a.Description)
                .IsRequired();

            builder.Property(a => a.Behavior)
                   .HasMaxLength(255);

            builder.Property(a => a.PhotoUrl)
                   .HasMaxLength(255);

            builder.Property(a => a.AudioUrl)
                   .HasMaxLength(255);

            builder.HasOne(a => a.Habitat)
                   .WithMany(h => h.Animals)
                   .HasForeignKey(a => a.HabitatId)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(a => a.Threats)
                   .WithMany(t => t.Animals);

            builder.HasMany(a => a.ConservationEfforts)
                   .WithOne(e => e.Animal)
                   .HasForeignKey(e => e.AnimalId)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.Property(a => a.HabitatId).IsRequired(false);
        }
    }
}
