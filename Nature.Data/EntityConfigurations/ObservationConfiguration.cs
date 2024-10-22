using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nature.Infrastructure.Entities;

namespace Nature.Data.EntityConfigurations
{
    public class ObservationConfiguration : IEntityTypeConfiguration<Observation>
    {
        public void Configure(EntityTypeBuilder<Observation> builder)
        {
            builder.ToTable("Observation");

            builder.HasKey(o => o.Id);
            builder.Property(o => o.Id).ValueGeneratedOnAdd();

            builder.Property(o => o.Date).IsRequired();
            builder.Property(o => o.Notes).HasMaxLength(500);


            builder.HasOne(o => o.Plant)
                   .WithMany()
                   .HasForeignKey(o => o.PlantId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(o => o.Animal)
                   .WithMany()
                   .HasForeignKey(o => o.AnimalId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}

//builder.HasOne(o => o.User)
//       .WithMany()
//       .HasForeignKey(o => o.UserId)
//       .OnDelete(DeleteBehavior.Cascade);