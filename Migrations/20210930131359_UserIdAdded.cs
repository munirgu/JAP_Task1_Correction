using Microsoft.EntityFrameworkCore.Migrations;

namespace JAP_Task_Backend.Migrations
{
    public partial class UserIdAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ratings_Users_userId",
                table: "Ratings");

            migrationBuilder.RenameColumn(
                name: "userId",
                table: "Ratings",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Ratings_userId",
                table: "Ratings",
                newName: "IX_Ratings_UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ratings_Users_UserId",
                table: "Ratings",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ratings_Users_UserId",
                table: "Ratings");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Ratings",
                newName: "userId");

            migrationBuilder.RenameIndex(
                name: "IX_Ratings_UserId",
                table: "Ratings",
                newName: "IX_Ratings_userId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ratings_Users_userId",
                table: "Ratings",
                column: "userId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
