using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nature.Data.Entities;

namespace Nature.Data.EntityConfigurations
{
    public class AnimalConfiguration : IEntityTypeConfiguration<Animal>
    {
        public void Configure(EntityTypeBuilder<Animal> builder)
        {
            builder.ToTable("Animal");

            builder.HasKey(a => a.Id);
            builder.Property(a => a.Id).ValueGeneratedOnAdd();

            builder.Property(a => a.Name)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(a => a.Description)
                .IsRequired();

            builder.Property(a => a.Habitat)
                .IsRequired();

            builder.Property(a => a.ImageFilePath)
                .IsRequired();

            builder.Property(a => a.SoundFilePath)
                .IsRequired(false);

            builder.Property(a => a.AnimalType)
                .IsRequired(false);

            builder.Property(a => a.Movement)
                .IsRequired()
                .HasConversion<int>();
        }
    }
}
