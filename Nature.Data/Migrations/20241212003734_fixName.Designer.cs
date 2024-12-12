﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Nature.Data.Context;

#nullable disable

namespace Nature.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241212003734_fixName")]
    partial class fixName
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.35")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("AnimalHabitat", b =>
                {
                    b.Property<Guid>("AnimalsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("HabitatsId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("AnimalsId", "HabitatsId");

                    b.HasIndex("HabitatsId");

                    b.ToTable("AnimalHabitat");
                });

            modelBuilder.Entity("HabitatPlant", b =>
                {
                    b.Property<Guid>("HabitatsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PlantsId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("HabitatsId", "PlantsId");

                    b.HasIndex("PlantsId");

                    b.ToTable("HabitatPlant");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Nature.Infrastructure.Entities.Animal", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Behavior")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Species")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Animals", (string)null);
                });

            modelBuilder.Entity("Nature.Infrastructure.Entities.AnimalAudio", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AnimalId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<byte[]>("AudioBytes")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.HasKey("Id");

                    b.HasIndex("AnimalId");

                    b.ToTable("AnimalAudios", (string)null);
                });

            modelBuilder.Entity("Nature.Infrastructure.Entities.AnimalSafekeeping", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AnimalId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("AnimalId1")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("AnimalId");

                    b.HasIndex("AnimalId1");

                    b.ToTable("AnimalSafekeepings", (string)null);
                });

            modelBuilder.Entity("Nature.Infrastructure.Entities.AnimalThreat", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AnimalId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("AnimalId1")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("AnimalId");

                    b.HasIndex("AnimalId1");

                    b.ToTable("AnimalThreats", (string)null);
                });

            modelBuilder.Entity("Nature.Infrastructure.Entities.AppUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Nature.Infrastructure.Entities.City", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CountryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Cities", (string)null);
                });

            modelBuilder.Entity("Nature.Infrastructure.Entities.Country", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Countries", (string)null);
                });

            modelBuilder.Entity("Nature.Infrastructure.Entities.Habitat", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<Guid>("ReserveAreaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ReserveAreaId1")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ReserveAreaId");

                    b.HasIndex("ReserveAreaId1");

                    b.ToTable("Habitats", (string)null);
                });

            modelBuilder.Entity("Nature.Infrastructure.Entities.MapPoint", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("Latitude")
                        .HasColumnType("float");

                    b.Property<double>("Longtitude")
                        .HasColumnType("float");

                    b.Property<Guid?>("ReserveAreaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ReserveAreaId1")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ReserveId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ReserveId1")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ReserveAreaId");

                    b.HasIndex("ReserveAreaId1");

                    b.HasIndex("ReserveId");

                    b.HasIndex("ReserveId1");

                    b.ToTable("MapPoints", (string)null);

                    b.HasCheckConstraint("CK_MapPoint_ReserveArea_Reserve", "[ReserveAreaId] IS NOT NULL AND [ReserveId] IS NULL OR [ReserveAreaId] IS NULL AND [ReserveId] IS NOT NULL");
                });

            modelBuilder.Entity("Nature.Infrastructure.Entities.Observation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("AnimalId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Notes")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<Guid?>("PlantId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("AnimalId");

                    b.HasIndex("PlantId");

                    b.ToTable("Observations", (string)null);

                    b.HasCheckConstraint("CK_Observation_Plant_Animal", "[PlantId] IS NOT NULL AND [AnimalId] IS NULL OR [PlantId] IS NULL AND [AnimalId] IS NOT NULL");
                });

            modelBuilder.Entity("Nature.Infrastructure.Entities.Photo", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("AnimalId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsPreview")
                        .HasColumnType("bit");

                    b.Property<byte[]>("PhotoBytes")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<Guid?>("PlantId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("AnimalId");

                    b.HasIndex("PlantId");

                    b.ToTable("Photos", (string)null);

                    b.HasCheckConstraint("CK_Photo_Plant_Animal", "[PlantId] IS NOT NULL AND [AnimalId] IS NULL OR [PlantId] IS NULL AND [AnimalId] IS NOT NULL");
                });

            modelBuilder.Entity("Nature.Infrastructure.Entities.Plant", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Species")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Plants", (string)null);
                });

            modelBuilder.Entity("Nature.Infrastructure.Entities.PlantSafekeeping", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<Guid>("PlantId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("PlantId");

                    b.ToTable("PlantSafekeepings", (string)null);
                });

            modelBuilder.Entity("Nature.Infrastructure.Entities.PlantThreat", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<Guid>("PlantId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("PlantId");

                    b.ToTable("PlantThreats", (string)null);
                });

            modelBuilder.Entity("Nature.Infrastructure.Entities.Reserve", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CityId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("Reserves", (string)null);
                });

            modelBuilder.Entity("Nature.Infrastructure.Entities.ReserveArea", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<Guid>("ReserveId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ReserveId");

                    b.ToTable("ReserveAreas", (string)null);
                });

            modelBuilder.Entity("Nature.Infrastructure.Entities.WeatherForecast", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AtmospherePressure")
                        .HasColumnType("int");

                    b.Property<int>("RainfallChance")
                        .HasColumnType("int");

                    b.Property<Guid>("ReserveId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<float>("TemperatureC")
                        .HasColumnType("real");

                    b.Property<float>("TemperatureF")
                        .HasColumnType("real");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("datetime2");

                    b.Property<float>("WindSpeed")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("ReserveId");

                    b.ToTable("WeatherForecasts", (string)null);
                });

            modelBuilder.Entity("AnimalHabitat", b =>
                {
                    b.HasOne("Nature.Infrastructure.Entities.Animal", null)
                        .WithMany()
                        .HasForeignKey("AnimalsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Nature.Infrastructure.Entities.Habitat", null)
                        .WithMany()
                        .HasForeignKey("HabitatsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HabitatPlant", b =>
                {
                    b.HasOne("Nature.Infrastructure.Entities.Habitat", null)
                        .WithMany()
                        .HasForeignKey("HabitatsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Nature.Infrastructure.Entities.Plant", null)
                        .WithMany()
                        .HasForeignKey("PlantsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.HasOne("Nature.Infrastructure.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.HasOne("Nature.Infrastructure.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Nature.Infrastructure.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.HasOne("Nature.Infrastructure.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Nature.Infrastructure.Entities.AnimalAudio", b =>
                {
                    b.HasOne("Nature.Infrastructure.Entities.Animal", "Animal")
                        .WithMany()
                        .HasForeignKey("AnimalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Animal");
                });

            modelBuilder.Entity("Nature.Infrastructure.Entities.AnimalSafekeeping", b =>
                {
                    b.HasOne("Nature.Infrastructure.Entities.Animal", "Animal")
                        .WithMany()
                        .HasForeignKey("AnimalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Nature.Infrastructure.Entities.Animal", null)
                        .WithMany("Safekeepings")
                        .HasForeignKey("AnimalId1");

                    b.Navigation("Animal");
                });

            modelBuilder.Entity("Nature.Infrastructure.Entities.AnimalThreat", b =>
                {
                    b.HasOne("Nature.Infrastructure.Entities.Animal", "Animal")
                        .WithMany()
                        .HasForeignKey("AnimalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Nature.Infrastructure.Entities.Animal", null)
                        .WithMany("Threats")
                        .HasForeignKey("AnimalId1");

                    b.Navigation("Animal");
                });

            modelBuilder.Entity("Nature.Infrastructure.Entities.City", b =>
                {
                    b.HasOne("Nature.Infrastructure.Entities.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("Nature.Infrastructure.Entities.Habitat", b =>
                {
                    b.HasOne("Nature.Infrastructure.Entities.ReserveArea", "ReserveArea")
                        .WithMany()
                        .HasForeignKey("ReserveAreaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Nature.Infrastructure.Entities.ReserveArea", null)
                        .WithMany("Habitats")
                        .HasForeignKey("ReserveAreaId1");

                    b.Navigation("ReserveArea");
                });

            modelBuilder.Entity("Nature.Infrastructure.Entities.MapPoint", b =>
                {
                    b.HasOne("Nature.Infrastructure.Entities.ReserveArea", "ReserveArea")
                        .WithMany()
                        .HasForeignKey("ReserveAreaId");

                    b.HasOne("Nature.Infrastructure.Entities.ReserveArea", null)
                        .WithMany("MapPoints")
                        .HasForeignKey("ReserveAreaId1");

                    b.HasOne("Nature.Infrastructure.Entities.Reserve", "Reserve")
                        .WithMany()
                        .HasForeignKey("ReserveId");

                    b.HasOne("Nature.Infrastructure.Entities.Reserve", null)
                        .WithMany("MapPoints")
                        .HasForeignKey("ReserveId1");

                    b.Navigation("Reserve");

                    b.Navigation("ReserveArea");
                });

            modelBuilder.Entity("Nature.Infrastructure.Entities.Observation", b =>
                {
                    b.HasOne("Nature.Infrastructure.Entities.Animal", "Animal")
                        .WithMany()
                        .HasForeignKey("AnimalId");

                    b.HasOne("Nature.Infrastructure.Entities.Plant", "Plant")
                        .WithMany()
                        .HasForeignKey("PlantId");

                    b.Navigation("Animal");

                    b.Navigation("Plant");
                });

            modelBuilder.Entity("Nature.Infrastructure.Entities.Photo", b =>
                {
                    b.HasOne("Nature.Infrastructure.Entities.Animal", "Animal")
                        .WithMany()
                        .HasForeignKey("AnimalId");

                    b.HasOne("Nature.Infrastructure.Entities.Plant", "Plant")
                        .WithMany()
                        .HasForeignKey("PlantId");

                    b.Navigation("Animal");

                    b.Navigation("Plant");
                });

            modelBuilder.Entity("Nature.Infrastructure.Entities.PlantSafekeeping", b =>
                {
                    b.HasOne("Nature.Infrastructure.Entities.Plant", "Plant")
                        .WithMany("Safekeepings")
                        .HasForeignKey("PlantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Plant");
                });

            modelBuilder.Entity("Nature.Infrastructure.Entities.PlantThreat", b =>
                {
                    b.HasOne("Nature.Infrastructure.Entities.Plant", "Plant")
                        .WithMany("Threats")
                        .HasForeignKey("PlantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Plant");
                });

            modelBuilder.Entity("Nature.Infrastructure.Entities.Reserve", b =>
                {
                    b.HasOne("Nature.Infrastructure.Entities.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("Nature.Infrastructure.Entities.ReserveArea", b =>
                {
                    b.HasOne("Nature.Infrastructure.Entities.Reserve", "Reserve")
                        .WithMany()
                        .HasForeignKey("ReserveId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Reserve");
                });

            modelBuilder.Entity("Nature.Infrastructure.Entities.WeatherForecast", b =>
                {
                    b.HasOne("Nature.Infrastructure.Entities.Reserve", "Reserve")
                        .WithMany()
                        .HasForeignKey("ReserveId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Reserve");
                });

            modelBuilder.Entity("Nature.Infrastructure.Entities.Animal", b =>
                {
                    b.Navigation("Safekeepings");

                    b.Navigation("Threats");
                });

            modelBuilder.Entity("Nature.Infrastructure.Entities.Plant", b =>
                {
                    b.Navigation("Safekeepings");

                    b.Navigation("Threats");
                });

            modelBuilder.Entity("Nature.Infrastructure.Entities.Reserve", b =>
                {
                    b.Navigation("MapPoints");
                });

            modelBuilder.Entity("Nature.Infrastructure.Entities.ReserveArea", b =>
                {
                    b.Navigation("Habitats");

                    b.Navigation("MapPoints");
                });
#pragma warning restore 612, 618
        }
    }
}