using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Nature.Infrastructure.Entities
{
    public class AnimalSafekeepingConfiguration : IEntityTypeConfiguration<AnimalSafekeeping>
    {
        public void Configure(EntityTypeBuilder<AnimalSafekeeping> builder)
        {
            // Configure the primary key
            builder.HasKey(a => a.Id);

            // Configure the properties
            builder.Property(a => a.Name)
                .IsRequired()
                .HasMaxLength(100); // Adjust the max length if needed

            builder.Property(a => a.Description)
                .HasMaxLength(500); // Optional: Adjust the max length as needed

            // Configure the foreign key relationship with Animal
            builder.HasOne(a => a.Animal)
                .WithMany() // Assuming a one-to-many relationship, where Animal has many AnimalSafekeepings
                .HasForeignKey(a => a.AnimalId)
                .IsRequired(); // Make sure the AnimalId is required

            // Optional: Table name
            builder.ToTable("AnimalSafekeepings");
        }
    }
}
