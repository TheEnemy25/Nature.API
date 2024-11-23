using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nature.Infrastructure.Enums;

namespace Nature.Infrastructure.Entities
{
    public class HabitatConfiguration : IEntityTypeConfiguration<Habitat>
    {
        public void Configure(EntityTypeBuilder<Habitat> builder)
        {
            // Configure the primary key
            builder.HasKey(h => h.Id);

            // Configure the properties
            builder.Property(h => h.Name)
                .IsRequired()
                .HasMaxLength(100); // Adjust the max length if needed

            builder.Property(h => h.Location)
                .IsRequired()
                .HasMaxLength(200); // Adjust the max length if needed

            // Configure enum Type as a string
            builder.Property(h => h.Type)
                .HasConversion(
                    v => v.ToString(), // Convert enum to string for storage
                    v => (EHabitatType)Enum.Parse(typeof(EHabitatType), v) // Convert string back to enum
                )
                .IsRequired(); // Ensure it's required if applicable

            // Configure the foreign key relationship with ReserveArea
            builder.HasOne(h => h.ReserveArea)
                .WithMany() // Assuming a one-to-many relationship, where ReserveArea has many Habitats
                .HasForeignKey(h => h.ReserveAreaId)
                .IsRequired(); // Make sure the ReserveAreaId is required

            // Optional: Table name
            builder.ToTable("Habitats");
        }
    }
}
