using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Nature.Infrastructure.Entities
{
    public class MapPointConfiguration : IEntityTypeConfiguration<MapPoint>
    {
        public void Configure(EntityTypeBuilder<MapPoint> builder)
        {
            // Configure the primary key
            builder.HasKey(mp => mp.Id);

            // Configure the properties
            builder.Property(mp => mp.Latitude)
                .IsRequired(); // Latitude is required

            builder.Property(mp => mp.Longtitude)
                .IsRequired(); // Longitude is required

            // Configure the optional ReserveAreaId and ReserveId
            builder.Property(mp => mp.ReserveAreaId)
                .IsRequired(false); // ReserveAreaId is optional

            builder.Property(mp => mp.ReserveId)
                .IsRequired(false); // ReserveId is optional

            // Ensure that either ReserveAreaId or ReserveId must have a value, but not both
            builder.HasCheckConstraint("CK_MapPoint_ReserveArea_Reserve",
                "[ReserveAreaId] IS NOT NULL AND [ReserveId] IS NULL OR [ReserveAreaId] IS NULL AND [ReserveId] IS NOT NULL");

            // Configure the foreign key relationships (optional)
            builder.HasOne(mp => mp.Reserve)
                .WithMany() // Assuming Reserve has many MapPoints
                .HasForeignKey(mp => mp.ReserveId);

            builder.HasOne(mp => mp.ReserveArea)
                .WithMany() // Assuming ReserveArea has many MapPoints
                .HasForeignKey(mp => mp.ReserveAreaId);

            // Optional: Table name
            builder.ToTable("MapPoints");
        }
    }
}
