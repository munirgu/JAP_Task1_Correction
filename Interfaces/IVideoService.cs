using JAP_Task_Backend.DTO;
using JAP_Task_Backend.Enums;
using JAP_Task_Backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JAP_Task_Backend.Interfaces
{
    public interface IVideoService
    {
        List<VideoDto> GetTopTenVideos(VideoType videoType, int currentPage);
        List<VideoDto> SearchMovies(VideoType videoType,string quickSearch);
        void RateVideo(int id, int score);
        void BuyTicket(int screeningId, int numberOfTickets);
        // Procedures
        List<TopTenMoviesByRatings> GetTopTenMoviesByRatings();
        List<TopTenMoviesByScreenings> GetTopTenMoviesByScreenings(DateTime startDate, DateTime endDate);
        List<TopMoviesByMostSoldTickets> GetTopMoviesByMostSoldTickets();
        // Test data
        void InsertScreeningData();
    }
}
