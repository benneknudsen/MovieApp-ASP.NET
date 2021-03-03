using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication2.Migrations
{
    public partial class Change : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "movieTitle",
                table: "Movie");

            migrationBuilder.AddColumn<int>(
                name: "movieApiId",
                table: "Movie",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "movieApiId",
                table: "Movie");

            migrationBuilder.AddColumn<string>(
                name: "movieTitle",
                table: "Movie",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
