using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nature.Infrastructure.Enums;

namespace Nature.Infrastructure.Entities
{
    public class HabitatConfiguration : IEntityTypeConfiguration<Habitat>
    {
        public void Configure(EntityTypeBuilder<Habitat> builder)
        {
            builder.HasKey(h => h.Id);

            builder.Property(h => h.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(h => h.Location)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(h => h.Type)
                .HasConversion(
                    v => v.ToString(),
                    v => (EHabitatType)Enum.Parse(typeof(EHabitatType), v)
                )
                .IsRequired(); 

            builder.HasOne(h => h.ReserveArea)
                .WithMany() // Assuming a one-to-many relationship, where ReserveArea has many Habitats
                .HasForeignKey(h => h.ReserveAreaId)
                .IsRequired(); // Make sure the ReserveAreaId is required

            builder.ToTable("Habitats");
        }
    }
}
