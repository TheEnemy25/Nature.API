using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nature.Infrastructure.Entities;

namespace Nature.Data.EntityConfigurations
{
    public class AnimalSafekeepingConfiguration : IEntityTypeConfiguration<AnimalSafekeeping>
    {
        public void Configure(EntityTypeBuilder<AnimalSafekeeping> builder)
        {
            builder.HasKey(a => a.Id);

            builder.Property(a => a.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(a => a.Description)
                .HasMaxLength(500);

            builder.HasOne(a => a.Animal)
                .WithMany()
                .HasForeignKey(a => a.AnimalId)
                .IsRequired();

            builder.ToTable("AnimalSafekeepings");
        }
    }
}
