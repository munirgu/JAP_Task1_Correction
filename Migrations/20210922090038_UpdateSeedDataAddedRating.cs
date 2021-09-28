using Microsoft.EntityFrameworkCore.Migrations;

namespace JAP_Task_Backend.Migrations
{
    public partial class UpdateSeedDataAddedRating : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "Score", "VideoId" },
                values: new object[] { 120, 0, 94 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 120);
        }
    }
}
