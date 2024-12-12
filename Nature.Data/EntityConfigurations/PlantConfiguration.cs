using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Nature.Infrastructure.Entities
{
    public class PlantConfiguration : IEntityTypeConfiguration<Plant>
    {
        public void Configure(EntityTypeBuilder<Plant> builder)
        {
            // Configure the primary key
            builder.HasKey(p => p.Id);

            // Configure the properties
            builder.Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(100); // Adjust the max length if needed

            builder.Property(p => p.Species)
                .IsRequired()
                .HasMaxLength(100); // Adjust the max length if needed

            builder.Property(p => p.Description)
                .HasMaxLength(500); // Optional: Adjust the max length as needed

            builder.Property(a => a.PhotoUrl)
    .HasMaxLength(500);

            // Optional: Table name
            builder.ToTable("Plants");
        }
    }
}
