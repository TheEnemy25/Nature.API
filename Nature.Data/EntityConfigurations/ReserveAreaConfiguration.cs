using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Nature.Infrastructure.Entities
{
    public class ReserveAreaConfiguration : IEntityTypeConfiguration<ReserveArea>
    {
        public void Configure(EntityTypeBuilder<ReserveArea> builder)
        {
            // Configure the primary key
            builder.HasKey(ra => ra.Id);

            // Configure the properties
            builder.Property(ra => ra.Name)
                .IsRequired()
                .HasMaxLength(100); // Adjust the max length if needed

            builder.Property(ra => ra.ReserveId)
                .IsRequired(); // Ensure ReserveId is required

            // Optional: Table name
            builder.ToTable("ReserveAreas");
        }
    }
}
