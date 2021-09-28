using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JAP_Task_Backend.Migrations
{
    public partial class AddedMoreActors : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Tom Hanks");

            migrationBuilder.UpdateData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Matt Damon");

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "ImageUrl", "ReleaseDate", "Title" },
                values: new object[] { "Saving Private Ryan is a 1998 American epic war film directed by Steven Spielberg and written by Robert Rodat. Set during the Invasion of Normandy in World War II, the film is known for its graphic portrayal of war, especially its depiction of the Omaha Beach assault during the Normandy landings.", "https://fanart.tv/fanart/movies/857/movieposter/saving-private-ryan-521a5ad8ab73e.jpg", new DateTime(1998, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Saving Private Ryan" });

            migrationBuilder.InsertData(
                table: "Videos",
                columns: new[] { "Id", "Description", "ImageUrl", "ReleaseDate", "Title", "Type" },
                values: new object[,]
                {
                    { 2, "Dominic Cobb is an industrial spy who instead of breaking into a person's home, office, or even computer, gets the information he needs by getting into the person's mind through their dreams.", "https://www.syfy.com/sites/syfy/files/styles/1170xauto/public/the-witcher-season-2-poster-vertical.jpg", new DateTime(2010, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inception", 1 },
                    { 3, "The witcher Geralt, a mutated monster hunter, struggles to find his place in a world in which people often prove more wicked than beasts.", "https://www.syfy.com/sites/syfy/files/styles/1170xauto/public/the-witcher-season-2-poster-vertical.jpg", new DateTime(2019, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Witcher", 1 },
                    { 4, "Forrest Gump is a 1994 American drama film directed by Robert Zemeckis and written by Eric Roth with comedic aspects. It is based on the 1986 novel of the same name by Winston Groom and stars Tom Hanks, Robin Wright, Gary Sinise, Mykelti Williamson and Sally Field.", "https://cinecalidad.in/wp-content/uploads/2020/03/forrest-gump-7240-poster-683x1024.jpg", new DateTime(1994, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Forrest Gump", 1 }
                });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "Score", "VideoId" },
                values: new object[,]
                {
                    { 3, 4, 2 },
                    { 4, 2, 2 },
                    { 5, 4, 3 },
                    { 6, 5, 3 },
                    { 7, 5, 4 },
                    { 8, 5, 4 }
                });

            migrationBuilder.InsertData(
                table: "VideoActors",
                columns: new[] { "Id", "Name", "VideoId" },
                values: new object[,]
                {
                    { 3, "Leonardo DiCaprio", 2 },
                    { 4, "Joseph Gordon-Levitt", 2 },
                    { 5, "Henry Cavill", 3 },
                    { 6, "Anna Shaffer", 3 },
                    { 7, "Tom Hanks", 4 },
                    { 8, "Robin Wright", 4 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Munir");

            migrationBuilder.UpdateData(
                table: "VideoActors",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Munir2");

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "ImageUrl", "ReleaseDate", "Title" },
                values: new object[] { "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency", "https://swank.azureedge.net/swank/prod-film/3560cd8a-9491-4ab9-876c-8a8d6b84a6dd/f8e7c904-669a-4c9f-ac29-d19b64b43e33/one-sheet.jpg?width=335&height=508&mode=crop", new DateTime(2021, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Shawshank Redemption" });
        }
    }
}
