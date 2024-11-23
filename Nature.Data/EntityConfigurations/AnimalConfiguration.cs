﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Nature.Infrastructure.Entities
{
    public class AnimalConfiguration : IEntityTypeConfiguration<Animal>
    {
        public void Configure(EntityTypeBuilder<Animal> builder)
        {
            // Configure the primary key
            builder.HasKey(a => a.Id);

            // Configure the properties
            builder.Property(a => a.Name)
                .IsRequired()
                .HasMaxLength(100); // Adjust the max length if needed

            builder.Property(a => a.Species)
                .IsRequired()
                .HasMaxLength(100); // Adjust the max length if needed

            builder.Property(a => a.Description)
                .HasMaxLength(500); // Optional: Adjust the max length as needed

            builder.Property(a => a.Behavior)
                .HasMaxLength(500); // Optional: Adjust the max length as needed

            // Optional: Table name
            builder.ToTable("Animals");
        }
    }
}
