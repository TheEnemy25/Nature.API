using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Nature.Infrastructure.Entities
{
    public class PlantThreatConfiguration : IEntityTypeConfiguration<PlantThreat>
    {
        public void Configure(EntityTypeBuilder<PlantThreat> builder)
        {
            // Configure the primary key
            builder.HasKey(pt => pt.Id);

            // Configure the properties
            builder.Property(pt => pt.Name)
                .IsRequired()
                .HasMaxLength(100); // Adjust the max length if needed

            builder.Property(pt => pt.Description)
                .HasMaxLength(500); // Optional: Adjust the max length as needed

            builder.Property(pt => pt.PlantId)
                .IsRequired(); // Ensure that PlantId is required

            // Optional: Table name
            builder.ToTable("PlantThreats");
        }
    }
}
