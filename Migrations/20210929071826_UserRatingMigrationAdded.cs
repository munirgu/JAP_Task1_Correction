using Microsoft.EntityFrameworkCore.Migrations;

namespace JAP_Task_Backend.Migrations
{
    public partial class UserRatingMigrationAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "userId",
                table: "Ratings",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_userId",
                table: "Ratings",
                column: "userId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ratings_Users_userId",
                table: "Ratings",
                column: "userId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ratings_Users_userId",
                table: "Ratings");

            migrationBuilder.DropIndex(
                name: "IX_Ratings_userId",
                table: "Ratings");

            migrationBuilder.DropColumn(
                name: "userId",
                table: "Ratings");
        }
    }
}
