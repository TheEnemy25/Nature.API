using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Nature.Infrastructure.Entities
{
    public class PhotoConfiguration : IEntityTypeConfiguration<Photo>
    {
        public void Configure(EntityTypeBuilder<Photo> builder)
        {
            // Configure the primary key
            builder.HasKey(p => p.Id);

            // Configure the properties
            builder.Property(p => p.PhotoBytes)
                .IsRequired(); // Ensure that PhotoBytes is required

            builder.Property(p => p.IsPreview)
                .IsRequired(); // Ensure that IsPreview is required

            // Configure the optional PlantId and AnimalId
            builder.Property(p => p.PlantId)
                .IsRequired(false); // PlantId is optional

            builder.Property(p => p.AnimalId)
                .IsRequired(false); // AnimalId is optional

            // Ensure that either PlantId or AnimalId must have a value, but not both
            builder.HasCheckConstraint("CK_Photo_Plant_Animal",
                "[PlantId] IS NOT NULL AND [AnimalId] IS NULL OR [PlantId] IS NULL AND [AnimalId] IS NOT NULL");

            // Configure the foreign key relationships
            builder.HasOne(p => p.Plant)
                .WithMany() // Assuming Plant has many Photos
                .HasForeignKey(p => p.PlantId);

            builder.HasOne(p => p.Animal)
                .WithMany() // Assuming Animal has many Photos
                .HasForeignKey(p => p.AnimalId);

            // Optional: Table name
            builder.ToTable("Photos");
        }
    }
}
