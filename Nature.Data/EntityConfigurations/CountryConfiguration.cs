using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Nature.Infrastructure.Entities
{
    public class CountryConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.HasKey(c => c.Id);

            // Configure the properties
            builder.Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.ToTable("Countries");
        }
    }
}
