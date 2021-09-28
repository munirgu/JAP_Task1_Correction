using Microsoft.EntityFrameworkCore.Migrations;

namespace JAP_Task_Backend.Migrations
{
    public partial class UpdateSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "Score", "VideoId" },
                values: new object[] { 118, 5, 92 });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "Score", "VideoId" },
                values: new object[] { 119, 3, 92 });

            migrationBuilder.UpdateData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 183,
                column: "VideoId",
                value: 92);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.UpdateData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 183,
                column: "VideoId",
                value: 93);
        }
    }
}
