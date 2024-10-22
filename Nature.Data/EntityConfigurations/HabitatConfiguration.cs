using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nature.Infrastructure.Entities;

namespace Nature.Data.EntityConfigurations
{
    public class HabitatConfiguration : IEntityTypeConfiguration<Habitat>
    {
        public void Configure(EntityTypeBuilder<Habitat> builder)
        {
            builder.ToTable("Habitat");

            builder.HasKey(h => h.Id);
            builder.Property(h => h.Id).ValueGeneratedOnAdd();

            builder.Property(h => h.Name).IsRequired().HasMaxLength(100);
            builder.Property(h => h.Location).HasMaxLength(255);
            builder.Property(h => h.Type).HasMaxLength(100);
        }
    }
}
