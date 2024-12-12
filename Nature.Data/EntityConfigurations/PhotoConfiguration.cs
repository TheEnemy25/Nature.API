using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Nature.Infrastructure.Entities
{
    public class PhotoConfiguration : IEntityTypeConfiguration<Photo>
    {
        public void Configure(EntityTypeBuilder<Photo> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.PhotoBytes)
                .IsRequired();

            builder.Property(p => p.IsPreview)
                .IsRequired();

            builder.Property(p => p.PlantId)
                .IsRequired(false);

            builder.Property(p => p.AnimalId)
                .IsRequired(false);

            builder.HasCheckConstraint("CK_Photo_Plant_Animal",
                "[PlantId] IS NOT NULL AND [AnimalId] IS NULL OR [PlantId] IS NULL AND [AnimalId] IS NOT NULL");

            builder.HasOne(p => p.Plant)
                .WithMany()
                .HasForeignKey(p => p.PlantId);

            builder.HasOne(p => p.Animal)
                .WithMany() 
                .HasForeignKey(p => p.AnimalId);

            builder.ToTable("Photos");
        }
    }
}
