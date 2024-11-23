using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Nature.Infrastructure.Entities
{
    public class PlantSafekeepingConfiguration : IEntityTypeConfiguration<PlantSafekeeping>
    {
        public void Configure(EntityTypeBuilder<PlantSafekeeping> builder)
        {
            // Configure the primary key
            builder.HasKey(ps => ps.Id);

            // Configure the properties
            builder.Property(ps => ps.Name)
                .IsRequired()
                .HasMaxLength(100); // Adjust the max length if needed

            builder.Property(ps => ps.Description)
                .HasMaxLength(500); // Optional: Adjust the max length as needed

            builder.Property(ps => ps.PlantId)
                .IsRequired(); // Ensure that PlantId is required

            // Optional: Table name
            builder.ToTable("PlantSafekeepings");
        }
    }
}
