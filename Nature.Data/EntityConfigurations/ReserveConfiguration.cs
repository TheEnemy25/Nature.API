using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Nature.Infrastructure.Entities
{
    public class ReserveConfiguration : IEntityTypeConfiguration<Reserve>
    {
        public void Configure(EntityTypeBuilder<Reserve> builder)
        {
            // Configure the primary key
            builder.HasKey(r => r.Id);

            // Configure the properties
            builder.Property(r => r.Name)
                .IsRequired(); // Adjust as needed

            builder.Property(r => r.CityId)
                .IsRequired(); // Ensure CityId is required

            // Optional: Table name
            builder.ToTable("Reserves");
        }
    }
}
