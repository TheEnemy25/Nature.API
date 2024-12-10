using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Nature.Infrastructure.Entities
{
    public class AnimalThreatConfiguration : IEntityTypeConfiguration<AnimalThreat>
    {
        public void Configure(EntityTypeBuilder<AnimalThreat> builder)
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

            builder.ToTable("AnimalThreats");
        }
    }
}
