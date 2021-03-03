using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication2.Migrations
{
    public partial class Change3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "userId",
                table: "Movie",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Movie_userId",
                table: "Movie",
                column: "userId");

            migrationBuilder.AddForeignKey(
                name: "FK_Movie_User_userId",
                table: "Movie",
                column: "userId",
                principalTable: "User",
                principalColumn: "userId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movie_User_userId",
                table: "Movie");

            migrationBuilder.DropIndex(
                name: "IX_Movie_userId",
                table: "Movie");

            migrationBuilder.DropColumn(
                name: "userId",
                table: "Movie");
        }
    }
}
