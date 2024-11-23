using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Nature.Infrastructure.Entities
{
    public class CityConfiguration : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            // Configure the primary key
            builder.HasKey(c => c.Id);

            // Configure the properties
            builder.Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(100); // Adjust the max length if needed

            // Configure the foreign key relationship with Country
            builder.HasOne(c => c.Country)
                .WithMany() // Assuming a one-to-many relationship, where Country has many Cities
                .HasForeignKey(c => c.CountryId)
                .IsRequired(); // Make sure the CountryId is required

            // Optional: Table name
            builder.ToTable("Cities");
        }
    }
}
