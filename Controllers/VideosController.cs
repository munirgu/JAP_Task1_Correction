using JAP_Task_Backend.Enums;
using JAP_Task_Backend.Errors;
using JAP_Task_Backend.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace JAP_Task_Backend.Controllers
{
    [ApiController]
    [Route("api/videos")]
    public class VideosController : Controller
    {
        private readonly IVideoService _videoService;
        public VideosController (IVideoService videoService) {

            _videoService = videoService;
        }

        [HttpGet("get-top-ten-movies")]
        public async Task<IActionResult> GetTopTenMovies(int currentPage)
        {
            var data = await _videoService.GetTopTenVideos(VideoType.Movie, currentPage);
            var response = new ApiException(200, data);
            return Ok(response);
        }

        [HttpGet("get-top-ten-shows")]
        public async Task<IActionResult> GetTopTenShows(int currentPage)
        {
            var data = await _videoService.GetTopTenVideos(VideoType.TvShow, currentPage);
            var response = new ApiException(200, data);
            return Ok(response);
        }

        [HttpGet("search-movie-videos")]
        public async Task<IActionResult> SearchMovies(string quickSearch)
        {
            var data = await _videoService.SearchMovies(VideoType.Movie, quickSearch);
            var response = new ApiException(200, data);
            return Ok(response);
        }

        [HttpGet("search-show-videos")]
        public async Task<IActionResult> SearchTvShows(string quickSearch)
        {
            var data = await _videoService.SearchMovies(VideoType.TvShow, quickSearch);
            var response = new ApiException(200, data);
            return Ok(response);
        }

        [HttpPost("buy-ticket")]
        public async Task<IActionResult> BuyTicket(int screeningId, int numberOfTickets)
        {
            await _videoService.BuyTicket(screeningId, numberOfTickets);
            var response = new ApiException(200);
            return Ok(response);
        }

        [HttpGet("top-ten-movies-by-ratings")]
        public async Task<IActionResult> GetTopTenMoviesByRatings()
        {
            var data = await _videoService.GetTopTenMoviesByRatings();
            var response = new ApiException(200, data);
            return Ok(response);
        }

        [HttpGet("top-ten-movies-by-screenings")]
        public async Task <IActionResult> GetTopTenMoviesByScreenings(DateTime startDate, DateTime endDate)
        {
            var data = await _videoService.GetTopTenMoviesByScreenings(startDate, endDate);
            var response = new ApiException(200, data);
            return Ok(response);
        }

        [HttpGet("top-movies-by-most-sold-tickets")]
        public async Task<IActionResult> GetTopMoviesByMostSoldTickets()
        {
            var data = await _videoService.GetTopMoviesByMostSoldTickets();
            var response = new ApiException(200, data);
            return Ok(response);
        }

        [HttpPost("insert-screening-data")]
        public async Task<IActionResult> InsertScreeningData()
        {
            await _videoService.InsertScreeningData();
            var response = new ApiException(200);
            return Ok(response);
        }
    }
}

