using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Nature.Infrastructure.Entities
{
    public class ObservationConfiguration : IEntityTypeConfiguration<Observation>
    {
        public void Configure(EntityTypeBuilder<Observation> builder)
        {
            // Configure the primary key
            builder.HasKey(o => o.Id);

            // Configure the properties
            builder.Property(o => o.Date)
                .IsRequired(); // Date is required

            builder.Property(o => o.Notes)
                .IsRequired()
                .HasMaxLength(500); // Notes is required, with a max length (adjust as needed)

            // Configure the optional PlantId and AnimalId
            builder.Property(o => o.PlantId)
                .IsRequired(false); // PlantId is optional

            builder.Property(o => o.AnimalId)
                .IsRequired(false); // AnimalId is optional

            // Ensure that either PlantId or AnimalId must have a value, but not both
            builder.HasCheckConstraint("CK_Observation_Plant_Animal",
                "[PlantId] IS NOT NULL AND [AnimalId] IS NULL OR [PlantId] IS NULL AND [AnimalId] IS NOT NULL");

            // Configure the foreign key relationships
            builder.HasOne(o => o.Plant)
                .WithMany() // Assuming Plant has many Observations
                .HasForeignKey(o => o.PlantId);

            builder.HasOne(o => o.Animal)
                .WithMany() // Assuming Animal has many Observations
                .HasForeignKey(o => o.AnimalId);

            // Optional: Table name
            builder.ToTable("Observations");
        }
    }
}
