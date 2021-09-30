using JAP_Task_Backend.DTO;
using JAP_Task_Backend.Enums;
using JAP_Task_Backend.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace JAP_Task_Backend.Interfaces
{
    public interface IVideoService
    {
        Task <List<VideoDto>> GetTopTenVideos(VideoType videoType, int currentPage);
        Task <List<VideoDto>> SearchMovies(VideoType videoType,string quickSearch);
        Task BuyTicket(int screeningId, int numberOfTickets);
        // Procedures
        Task <List<TopTenMoviesByRatings>>GetTopTenMoviesByRatings();
        Task <List<TopTenMoviesByScreenings>> GetTopTenMoviesByScreenings(DateTime startDate, DateTime endDate);
        Task <List<TopMoviesByMostSoldTickets>> GetTopMoviesByMostSoldTickets();
        // Test data
        Task InsertScreeningData();
    }
}
