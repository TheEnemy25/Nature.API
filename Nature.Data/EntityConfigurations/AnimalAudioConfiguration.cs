using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Nature.Infrastructure.Entities
{
    public class AnimalAudioConfiguration : IEntityTypeConfiguration<AnimalAudio>
    {
        public void Configure(EntityTypeBuilder<AnimalAudio> builder)
        {
            // Configure the primary key
            builder.HasKey(aa => aa.Id);

            // Configure the properties
            builder.Property(aa => aa.AudioBytes)
                .IsRequired(); // Ensure AudioBytes is required

            // Configure the foreign key relationship with Animal
            builder.HasOne(aa => aa.Animal)
                .WithMany() // Assuming a one-to-many relationship, where Animal has many AnimalAudios
                .HasForeignKey(aa => aa.AnimalId)
                .IsRequired(); // Make sure the AnimalId is required

            // Optional: Table name
            builder.ToTable("AnimalAudios");
        }
    }
}
