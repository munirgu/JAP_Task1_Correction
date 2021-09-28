using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JAP_Task_Backend.Migrations
{
    public partial class AddedGetTopTenMoviesProcedure : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Videos",
                columns: new[] { "Id", "Description", "ImageUrl", "ReleaseDate", "Title", "Type" },
                values: new object[] { 31, "When bitten by a genetically modified spider, a nerdy, shy, and awkward high school student gains spider-like abilities that he eventually must use to fight evil as a superhero after tragedy befalls his family.", "https://media.movieassets.com/static/images/items/movies/posters/500/100/spider-man-c09f709a5db1cd7d6c3dabb678d908e5.jpg", new DateTime(2012, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Spider", 1 });
            migrationBuilder.Sql(@"SET ANSI_NULLS ON
                GO
                SET QUOTED_IDENTIFIER ON
                GO

                CREATE OR ALTER PROCEDURE GetTopTenMovies

                AS
                BEGIN
	
	                SET NOCOUNT ON;

	                SELECT  TOP(10) v.Id,v.Title,Count(a.Id) AS RatingCount, Avg (a.Score) AS Rating
	                FROM Videos v
	                LEFT JOIN Ratings a ON (v.Id = a.VideoId)
	                WHERE v.Type = 1 
	                GROUP BY v.Id , v.Title
	                ORDER BY Rating DESC;

                END
                GO");
        }

        
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 31);
        }
    }
}
