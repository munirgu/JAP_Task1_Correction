using Microsoft.EntityFrameworkCore.Migrations;

namespace JAP_Task_Backend.Migrations
{
    public partial class AddedVideoActors : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VideoActors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VideoId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VideoActors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VideoActors_Videos_VideoId",
                        column: x => x.VideoId,
                        principalTable: "Videos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "VideoActors",
                columns: new[] { "Id", "Name", "VideoId" },
                values: new object[] { 1, "Munir", 1 });

            migrationBuilder.InsertData(
                table: "VideoActors",
                columns: new[] { "Id", "Name", "VideoId" },
                values: new object[] { 2, "Munir2", 1 });

            migrationBuilder.CreateIndex(
                name: "IX_VideoActors_VideoId",
                table: "VideoActors",
                column: "VideoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VideoActors");
        }
    }
}
