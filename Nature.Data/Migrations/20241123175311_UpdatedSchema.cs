using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nature.Data.Migrations
{
    public partial class UpdatedSchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Animal_Habitat_HabitatId",
                table: "Animal");

            migrationBuilder.DropForeignKey(
                name: "FK_Observation_Animal_AnimalId",
                table: "Observation");

            migrationBuilder.DropForeignKey(
                name: "FK_Observation_Plant_PlantId",
                table: "Observation");

            migrationBuilder.DropForeignKey(
                name: "FK_Plant_Habitat_HabitatId",
                table: "Plant");

            migrationBuilder.DropTable(
                name: "AnimalThreat");

            migrationBuilder.DropTable(
                name: "ConservationEffort");

            migrationBuilder.DropTable(
                name: "PlantThreat");

            migrationBuilder.DropTable(
                name: "Threat");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Plant",
                table: "Plant");

            migrationBuilder.DropIndex(
                name: "IX_Plant_HabitatId",
                table: "Plant");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Observation",
                table: "Observation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Habitat",
                table: "Habitat");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Animal",
                table: "Animal");

            migrationBuilder.DropIndex(
                name: "IX_Animal_HabitatId",
                table: "Animal");

            migrationBuilder.DropColumn(
                name: "AudioUrl",
                table: "Plant");

            migrationBuilder.DropColumn(
                name: "HabitatId",
                table: "Plant");

            migrationBuilder.DropColumn(
                name: "PhotoUrl",
                table: "Plant");

            migrationBuilder.DropColumn(
                name: "AudioUrl",
                table: "Animal");

            migrationBuilder.DropColumn(
                name: "HabitatId",
                table: "Animal");

            migrationBuilder.DropColumn(
                name: "PhotoUrl",
                table: "Animal");

            migrationBuilder.RenameTable(
                name: "Plant",
                newName: "Plants");

            migrationBuilder.RenameTable(
                name: "Observation",
                newName: "Observations");

            migrationBuilder.RenameTable(
                name: "Habitat",
                newName: "Habitats");

            migrationBuilder.RenameTable(
                name: "Animal",
                newName: "Animals");

            migrationBuilder.RenameIndex(
                name: "IX_Observation_PlantId",
                table: "Observations",
                newName: "IX_Observations_PlantId");

            migrationBuilder.RenameIndex(
                name: "IX_Observation_AnimalId",
                table: "Observations",
                newName: "IX_Observations_AnimalId");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Plants",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<Guid>(
                name: "PlantId",
                table: "Observations",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "AnimalId",
                table: "Observations",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "Habitats",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Location",
                table: "Habitats",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AddColumn<Guid>(
                name: "ReserveAreaId",
                table: "Habitats",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "ReserveAreaId1",
                table: "Habitats",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Animals",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Animals",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Behavior",
                table: "Animals",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Plants",
                table: "Plants",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Observations",
                table: "Observations",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Habitats",
                table: "Habitats",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Animals",
                table: "Animals",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "AnimalAudios",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AudioBytes = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    AnimalId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnimalAudios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AnimalAudios_Animals_AnimalId",
                        column: x => x.AnimalId,
                        principalTable: "Animals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AnimalHabitat",
                columns: table => new
                {
                    AnimalsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HabitatsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnimalHabitat", x => new { x.AnimalsId, x.HabitatsId });
                    table.ForeignKey(
                        name: "FK_AnimalHabitat_Animals_AnimalsId",
                        column: x => x.AnimalsId,
                        principalTable: "Animals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AnimalHabitat_Habitats_HabitatsId",
                        column: x => x.HabitatsId,
                        principalTable: "Habitats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AnimalSafekeepings",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    AnimalId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AnimalId1 = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnimalSafekeepings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AnimalSafekeepings_Animals_AnimalId",
                        column: x => x.AnimalId,
                        principalTable: "Animals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AnimalSafekeepings_Animals_AnimalId1",
                        column: x => x.AnimalId1,
                        principalTable: "Animals",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AnimalThreats",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    AnimalId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AnimalId1 = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnimalThreats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AnimalThreats_Animals_AnimalId",
                        column: x => x.AnimalId,
                        principalTable: "Animals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AnimalThreats_Animals_AnimalId1",
                        column: x => x.AnimalId1,
                        principalTable: "Animals",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HabitatPlant",
                columns: table => new
                {
                    HabitatsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PlantsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HabitatPlant", x => new { x.HabitatsId, x.PlantsId });
                    table.ForeignKey(
                        name: "FK_HabitatPlant_Habitats_HabitatsId",
                        column: x => x.HabitatsId,
                        principalTable: "Habitats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HabitatPlant_Plants_PlantsId",
                        column: x => x.PlantsId,
                        principalTable: "Plants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Photos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PhotoBytes = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    IsPreview = table.Column<bool>(type: "bit", nullable: false),
                    PlantId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AnimalId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photos", x => x.Id);
                    table.CheckConstraint("CK_Photo_Plant_Animal", "[PlantId] IS NOT NULL AND [AnimalId] IS NULL OR [PlantId] IS NULL AND [AnimalId] IS NOT NULL");
                    table.ForeignKey(
                        name: "FK_Photos_Animals_AnimalId",
                        column: x => x.AnimalId,
                        principalTable: "Animals",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Photos_Plants_PlantId",
                        column: x => x.PlantId,
                        principalTable: "Plants",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PlantSafekeepings",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    PlantId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlantSafekeepings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlantSafekeepings_Plants_PlantId",
                        column: x => x.PlantId,
                        principalTable: "Plants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlantThreats",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    PlantId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlantThreats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlantThreats_Plants_PlantId",
                        column: x => x.PlantId,
                        principalTable: "Plants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CountryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cities_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reserves",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reserves", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reserves_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReserveAreas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ReserveId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReserveAreas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReserveAreas_Reserves_ReserveId",
                        column: x => x.ReserveId,
                        principalTable: "Reserves",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WeatherForecasts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Timestamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TemperatureC = table.Column<float>(type: "real", nullable: false),
                    TemperatureF = table.Column<float>(type: "real", nullable: false),
                    AtmospherePressure = table.Column<int>(type: "int", nullable: false),
                    RainfallChance = table.Column<int>(type: "int", nullable: false),
                    WindSpeed = table.Column<float>(type: "real", nullable: false),
                    ReserveId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeatherForecasts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WeatherForecasts_Reserves_ReserveId",
                        column: x => x.ReserveId,
                        principalTable: "Reserves",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MapPoints",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Latitude = table.Column<double>(type: "float", nullable: false),
                    Longtitude = table.Column<double>(type: "float", nullable: false),
                    ReserveAreaId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ReserveId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ReserveAreaId1 = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ReserveId1 = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MapPoints", x => x.Id);
                    table.CheckConstraint("CK_MapPoint_ReserveArea_Reserve", "[ReserveAreaId] IS NOT NULL AND [ReserveId] IS NULL OR [ReserveAreaId] IS NULL AND [ReserveId] IS NOT NULL");
                    table.ForeignKey(
                        name: "FK_MapPoints_ReserveAreas_ReserveAreaId",
                        column: x => x.ReserveAreaId,
                        principalTable: "ReserveAreas",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MapPoints_ReserveAreas_ReserveAreaId1",
                        column: x => x.ReserveAreaId1,
                        principalTable: "ReserveAreas",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MapPoints_Reserves_ReserveId",
                        column: x => x.ReserveId,
                        principalTable: "Reserves",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MapPoints_Reserves_ReserveId1",
                        column: x => x.ReserveId1,
                        principalTable: "Reserves",
                        principalColumn: "Id");
                });

            migrationBuilder.AddCheckConstraint(
                name: "CK_Observation_Plant_Animal",
                table: "Observations",
                sql: "[PlantId] IS NOT NULL AND [AnimalId] IS NULL OR [PlantId] IS NULL AND [AnimalId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Habitats_ReserveAreaId",
                table: "Habitats",
                column: "ReserveAreaId");

            migrationBuilder.CreateIndex(
                name: "IX_Habitats_ReserveAreaId1",
                table: "Habitats",
                column: "ReserveAreaId1");

            migrationBuilder.CreateIndex(
                name: "IX_AnimalAudios_AnimalId",
                table: "AnimalAudios",
                column: "AnimalId");

            migrationBuilder.CreateIndex(
                name: "IX_AnimalHabitat_HabitatsId",
                table: "AnimalHabitat",
                column: "HabitatsId");

            migrationBuilder.CreateIndex(
                name: "IX_AnimalSafekeepings_AnimalId",
                table: "AnimalSafekeepings",
                column: "AnimalId");

            migrationBuilder.CreateIndex(
                name: "IX_AnimalSafekeepings_AnimalId1",
                table: "AnimalSafekeepings",
                column: "AnimalId1");

            migrationBuilder.CreateIndex(
                name: "IX_AnimalThreats_AnimalId",
                table: "AnimalThreats",
                column: "AnimalId");

            migrationBuilder.CreateIndex(
                name: "IX_AnimalThreats_AnimalId1",
                table: "AnimalThreats",
                column: "AnimalId1");

            migrationBuilder.CreateIndex(
                name: "IX_Cities_CountryId",
                table: "Cities",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_HabitatPlant_PlantsId",
                table: "HabitatPlant",
                column: "PlantsId");

            migrationBuilder.CreateIndex(
                name: "IX_MapPoints_ReserveAreaId",
                table: "MapPoints",
                column: "ReserveAreaId");

            migrationBuilder.CreateIndex(
                name: "IX_MapPoints_ReserveAreaId1",
                table: "MapPoints",
                column: "ReserveAreaId1");

            migrationBuilder.CreateIndex(
                name: "IX_MapPoints_ReserveId",
                table: "MapPoints",
                column: "ReserveId");

            migrationBuilder.CreateIndex(
                name: "IX_MapPoints_ReserveId1",
                table: "MapPoints",
                column: "ReserveId1");

            migrationBuilder.CreateIndex(
                name: "IX_Photos_AnimalId",
                table: "Photos",
                column: "AnimalId");

            migrationBuilder.CreateIndex(
                name: "IX_Photos_PlantId",
                table: "Photos",
                column: "PlantId");

            migrationBuilder.CreateIndex(
                name: "IX_PlantSafekeepings_PlantId",
                table: "PlantSafekeepings",
                column: "PlantId");

            migrationBuilder.CreateIndex(
                name: "IX_PlantThreats_PlantId",
                table: "PlantThreats",
                column: "PlantId");

            migrationBuilder.CreateIndex(
                name: "IX_ReserveAreas_ReserveId",
                table: "ReserveAreas",
                column: "ReserveId");

            migrationBuilder.CreateIndex(
                name: "IX_Reserves_CityId",
                table: "Reserves",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_WeatherForecasts_ReserveId",
                table: "WeatherForecasts",
                column: "ReserveId");

            migrationBuilder.AddForeignKey(
                name: "FK_Habitats_ReserveAreas_ReserveAreaId",
                table: "Habitats",
                column: "ReserveAreaId",
                principalTable: "ReserveAreas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Habitats_ReserveAreas_ReserveAreaId1",
                table: "Habitats",
                column: "ReserveAreaId1",
                principalTable: "ReserveAreas",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Observations_Animals_AnimalId",
                table: "Observations",
                column: "AnimalId",
                principalTable: "Animals",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Observations_Plants_PlantId",
                table: "Observations",
                column: "PlantId",
                principalTable: "Plants",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Habitats_ReserveAreas_ReserveAreaId",
                table: "Habitats");

            migrationBuilder.DropForeignKey(
                name: "FK_Habitats_ReserveAreas_ReserveAreaId1",
                table: "Habitats");

            migrationBuilder.DropForeignKey(
                name: "FK_Observations_Animals_AnimalId",
                table: "Observations");

            migrationBuilder.DropForeignKey(
                name: "FK_Observations_Plants_PlantId",
                table: "Observations");

            migrationBuilder.DropTable(
                name: "AnimalAudios");

            migrationBuilder.DropTable(
                name: "AnimalHabitat");

            migrationBuilder.DropTable(
                name: "AnimalSafekeepings");

            migrationBuilder.DropTable(
                name: "AnimalThreats");

            migrationBuilder.DropTable(
                name: "HabitatPlant");

            migrationBuilder.DropTable(
                name: "MapPoints");

            migrationBuilder.DropTable(
                name: "Photos");

            migrationBuilder.DropTable(
                name: "PlantSafekeepings");

            migrationBuilder.DropTable(
                name: "PlantThreats");

            migrationBuilder.DropTable(
                name: "WeatherForecasts");

            migrationBuilder.DropTable(
                name: "ReserveAreas");

            migrationBuilder.DropTable(
                name: "Reserves");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Plants",
                table: "Plants");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Observations",
                table: "Observations");

            migrationBuilder.DropCheckConstraint(
                name: "CK_Observation_Plant_Animal",
                table: "Observations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Habitats",
                table: "Habitats");

            migrationBuilder.DropIndex(
                name: "IX_Habitats_ReserveAreaId",
                table: "Habitats");

            migrationBuilder.DropIndex(
                name: "IX_Habitats_ReserveAreaId1",
                table: "Habitats");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Animals",
                table: "Animals");

            migrationBuilder.DropColumn(
                name: "ReserveAreaId",
                table: "Habitats");

            migrationBuilder.DropColumn(
                name: "ReserveAreaId1",
                table: "Habitats");

            migrationBuilder.RenameTable(
                name: "Plants",
                newName: "Plant");

            migrationBuilder.RenameTable(
                name: "Observations",
                newName: "Observation");

            migrationBuilder.RenameTable(
                name: "Habitats",
                newName: "Habitat");

            migrationBuilder.RenameTable(
                name: "Animals",
                newName: "Animal");

            migrationBuilder.RenameIndex(
                name: "IX_Observations_PlantId",
                table: "Observation",
                newName: "IX_Observation_PlantId");

            migrationBuilder.RenameIndex(
                name: "IX_Observations_AnimalId",
                table: "Observation",
                newName: "IX_Observation_AnimalId");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Plant",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AudioUrl",
                table: "Plant",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<Guid>(
                name: "HabitatId",
                table: "Plant",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "PhotoUrl",
                table: "Plant",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<Guid>(
                name: "PlantId",
                table: "Observation",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "AnimalId",
                table: "Observation",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "Habitat",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Location",
                table: "Habitat",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Animal",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Animal",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Behavior",
                table: "Animal",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AudioUrl",
                table: "Animal",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<Guid>(
                name: "HabitatId",
                table: "Animal",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhotoUrl",
                table: "Animal",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Plant",
                table: "Plant",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Observation",
                table: "Observation",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Habitat",
                table: "Habitat",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Animal",
                table: "Animal",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "ConservationEffort",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AnimalId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PlantId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConservationEffort", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ConservationEffort_Animal_AnimalId",
                        column: x => x.AnimalId,
                        principalTable: "Animal",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ConservationEffort_Plant_PlantId",
                        column: x => x.PlantId,
                        principalTable: "Plant",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Threat",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Threat", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AnimalThreat",
                columns: table => new
                {
                    AnimalsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ThreatsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnimalThreat", x => new { x.AnimalsId, x.ThreatsId });
                    table.ForeignKey(
                        name: "FK_AnimalThreat_Animal_AnimalsId",
                        column: x => x.AnimalsId,
                        principalTable: "Animal",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AnimalThreat_Threat_ThreatsId",
                        column: x => x.ThreatsId,
                        principalTable: "Threat",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlantThreat",
                columns: table => new
                {
                    PlantsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ThreatsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlantThreat", x => new { x.PlantsId, x.ThreatsId });
                    table.ForeignKey(
                        name: "FK_PlantThreat_Plant_PlantsId",
                        column: x => x.PlantsId,
                        principalTable: "Plant",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlantThreat_Threat_ThreatsId",
                        column: x => x.ThreatsId,
                        principalTable: "Threat",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Plant_HabitatId",
                table: "Plant",
                column: "HabitatId");

            migrationBuilder.CreateIndex(
                name: "IX_Animal_HabitatId",
                table: "Animal",
                column: "HabitatId");

            migrationBuilder.CreateIndex(
                name: "IX_AnimalThreat_ThreatsId",
                table: "AnimalThreat",
                column: "ThreatsId");

            migrationBuilder.CreateIndex(
                name: "IX_ConservationEffort_AnimalId",
                table: "ConservationEffort",
                column: "AnimalId");

            migrationBuilder.CreateIndex(
                name: "IX_ConservationEffort_PlantId",
                table: "ConservationEffort",
                column: "PlantId");

            migrationBuilder.CreateIndex(
                name: "IX_PlantThreat_ThreatsId",
                table: "PlantThreat",
                column: "ThreatsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Animal_Habitat_HabitatId",
                table: "Animal",
                column: "HabitatId",
                principalTable: "Habitat",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Observation_Animal_AnimalId",
                table: "Observation",
                column: "AnimalId",
                principalTable: "Animal",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Observation_Plant_PlantId",
                table: "Observation",
                column: "PlantId",
                principalTable: "Plant",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Plant_Habitat_HabitatId",
                table: "Plant",
                column: "HabitatId",
                principalTable: "Habitat",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
