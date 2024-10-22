using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nature.Infrastructure.Entities;

namespace Nature.Data.EntityConfigurations
{
    public class ConservationEffortConfiguration : IEntityTypeConfiguration<ConservationEffort>
    {
        public void Configure(EntityTypeBuilder<ConservationEffort> builder)
        {
            builder.ToTable("ConservationEffort");

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).ValueGeneratedOnAdd();

            builder.Property(e => e.Name)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.Property(e => e.Description)
                   .HasMaxLength(255);

            builder.HasOne(e => e.Animal)
                   .WithMany(a => a.ConservationEfforts)
                   .HasForeignKey(e => e.AnimalId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(e => e.Plant)
                   .WithMany(p => p.ConservationEfforts)
                   .HasForeignKey(e => e.PlantId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
