using Microsoft.EntityFrameworkCore.Migrations;

namespace JAP_Task_Backend.Migrations
{
    public partial class AddedGetTopTenMoviesByScreeningProcedure : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"SET ANSI_NULLS ON
                GO
                SET QUOTED_IDENTIFIER ON
                GO

                CREATE OR ALTER PROCEDURE GetTopTenMoviesByScreenings
	            @StartDate date,
	            @EndDate date
                AS
                BEGIN

	            SELECT TOP(10) v.Id, v.Title, Count(s.Id) AS ScreeningsCount
	            FROM Videos v
	            LEFT JOIN Screenings s ON v.Id = s.VideoId AND CAST(s.DateAndTime as date) BETWEEN @StartDate AND @EndDate
	            WHERE v.Type = 1 
	            GROUP BY v.Id , v.Title
	            ORDER BY ScreeningsCount DESC
            END
            GO");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
