using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nature.Data.Migrations
{
    public partial class fixphoto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PhotoUrl",
                table: "Plants",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AudioUrl",
                table: "Animals",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhotoUrl",
                table: "Animals",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PhotoUrl",
                table: "Plants");

            migrationBuilder.DropColumn(
                name: "AudioUrl",
                table: "Animals");

            migrationBuilder.DropColumn(
                name: "PhotoUrl",
                table: "Animals");
        }
    }
}
