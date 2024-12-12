using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nature.Infrastructure.Entities;

namespace Nature.Data.EntityConfigurations
{
    public class AnimalAudioConfiguration : IEntityTypeConfiguration<AnimalAudio>
    {
        public void Configure(EntityTypeBuilder<AnimalAudio> builder)
        {
            builder.HasKey(aa => aa.Id);

            builder.Property(aa => aa.AudioBytes)
                .IsRequired(); 

            builder.HasOne(aa => aa.Animal)
                .WithMany() 
                .HasForeignKey(aa => aa.AnimalId)
                .IsRequired(); 

            builder.ToTable("AnimalAudios");
        }
    }
}
