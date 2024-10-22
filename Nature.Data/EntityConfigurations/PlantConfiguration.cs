using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nature.Data.Entities;

namespace Nature.Data.EntityConfigurations
{
    public class PlantConfiguration : IEntityTypeConfiguration<Plant>
    {
        public void Configure(EntityTypeBuilder<Plant> builder)
        {
            builder.ToTable("Plant");

            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).ValueGeneratedOnAdd();

            builder.Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(p => p.Description)
                .IsRequired();

            builder.Property(p => p.Habitat)
                .IsRequired();

            builder.Property(p => p.ImageFilePath)
                .IsRequired();
        }
    }
}
