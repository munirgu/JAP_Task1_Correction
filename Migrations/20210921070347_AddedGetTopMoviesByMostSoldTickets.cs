using Microsoft.EntityFrameworkCore.Migrations;

namespace JAP_Task_Backend.Migrations
{
    public partial class AddedGetTopMoviesByMostSoldTickets : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"SET ANSI_NULLS ON
                GO
                SET QUOTED_IDENTIFIER ON
                GO

                CREATE OR ALTER PROCEDURE GetTopMoviesByMostSoldTickets
                    AS
                    BEGIN

                SET NOCOUNT ON;

	            SELECT TOP(10) v.Id,s.Id AS ScreeningId, v.Title,s.DateAndTime, s.SoldTickets
	            FROM Videos v
	            INNER JOIN Screenings s ON v.Id = s.VideoId AND s.SoldTickets > 0
	            LEFT JOIN Ratings a ON (v.Id = a.VideoId)
	            WHERE v.Type = 1  
	            GROUP BY v.Id, s.Id, v.Title,s.DateAndTime, s.SoldTickets
	            HAVING Count(a.Id) = 0
	            ORDER BY s.SoldTickets DESC
            END
            GO");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
