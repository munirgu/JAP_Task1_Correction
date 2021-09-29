using JAP_Task_Backend.Database;
using JAP_Task_Backend.DTO;
using JAP_Task_Backend.Enums;
using JAP_Task_Backend.Interfaces;
using JAP_Task_Backend.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JAP_Task_Backend.Services
{
    public class VideoService : IVideoService
    {
        private readonly ApplicationDbContext _context;
        private const int pageSize = 10;
        private readonly Random _random = new Random();
        public VideoService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<VideoDto>> GetTopTenVideos(VideoType videoType, int currentPage = 1)
        {
            if (currentPage < 1)
                currentPage = 1;
            var videos =_context.Videos
                .Where(w => w.Type == videoType)
                .Select(s => new VideoDto
                {
                    Id = s.Id,
                    Title = s.Title,
                    Description = s.Description,
                    ReleaseDate = s.ReleaseDate,
                    ImageUrl = s.ImageUrl,
                    Rating = Math.Round(s.Ratings.Average(a => a.Score), 1),
                    Actors = s.Actors.Select(x => x.FirstName + " " + x.LastName).ToList()
                })
                .OrderByDescending(o => o.Rating)
                .Skip((currentPage - 1) * pageSize)
                .Take(pageSize)
                .ToList();
            return videos;
        }

        public async Task<List<VideoDto>> SearchMovies(VideoType videoType, string quickSearch)
        {
            List<VideoDto> videos = new List<VideoDto>();
            // at least X stars
            if (quickSearch.ToLower().StartsWith("at least ") && quickSearch.ToLower().EndsWith(" stars"))
            {
                quickSearch = quickSearch.ToLower().Replace("at least ", "").Replace(" stars", "");
                if (int.TryParse(quickSearch, out int score))
                {
                    videos = await SearchByAtLeastRating(videoType, score);
                }
            }
            // ends with stars (X stars)
            else if (quickSearch.ToLower().EndsWith(" stars"))
            {
                quickSearch = quickSearch.ToLower().Replace(" stars", "");
                if (int.TryParse(quickSearch, out int score))
                {
                    videos = await SearchByRating (videoType, score);
                }
            }
            // after years
            else if (quickSearch.ToLower().StartsWith("after "))
            {
                quickSearch = quickSearch.ToLower().Replace("after ", "");
                if (int.TryParse(quickSearch, out int score))
                {
                    videos = await SearchByAfterYear(videoType, score);
                }
            }
            // older than X years
            else if (quickSearch.ToLower().StartsWith("older than ") && quickSearch.ToLower().EndsWith(" years"))
            {
                quickSearch = quickSearch.ToLower().Replace("older than ", "").Replace(" years", "");
                if (int.TryParse(quickSearch, out int score))
                {
                    videos = await SearchByOlderThanYears(videoType, score);
                }
            }
            else
            {
                videos = await SearchByTitleAndDescription(videoType, quickSearch);
            }

            return videos;
        }
        private async Task<List<VideoDto>> SearchByTitleAndDescription(VideoType videoType, string quickSearch)
        {
            return _context.Videos
                        .Where(w => w.Type == videoType &&
                                (w.Title.ToLower().Contains(quickSearch.ToLower()) ||
                                w.Description.ToLower().Contains(quickSearch.ToLower())))
                        .Select(s => new VideoDto
                        {
                            Id = s.Id,
                            Title = s.Title,
                            Description = s.Description,
                            ReleaseDate = s.ReleaseDate,
                            ImageUrl = s.ImageUrl,
                            Rating = Math.Round(s.Ratings.Average(a => a.Score), 1),
                            Actors = s.Actors.Select(x => x.FirstName + " " + x.LastName).ToList()
                        })
                        .OrderByDescending(o => o.Rating)
                        .ToList();
        }

        private async Task<List<VideoDto>> SearchByAtLeastRating(VideoType videoType, int score)
        {
            return _context.Videos
                        .Where(w => w.Type == videoType &&
                                    w.Ratings.Average(a => a.Score) >= score)
                        .Select(s => new VideoDto
                        {
                            Id = s.Id,
                            Title = s.Title,
                            Description = s.Description,
                            ReleaseDate = s.ReleaseDate,
                            ImageUrl = s.ImageUrl,
                            Rating = Math.Round(s.Ratings.Average(a => a.Score), 1),
                            Actors = s.Actors.Select(x => x.FirstName + " " + x.LastName).ToList()
                        })
                        .OrderByDescending(o => o.Rating)
                        .ToList();
        }
        private async Task<List<VideoDto>> SearchByRating(VideoType videoType, int score)
        {
            return _context.Videos
                        .Where(w => w.Type == videoType &&
                                    w.Ratings.Average(a => a.Score) == score)
                        .Select(s => new VideoDto
                        {
                            Id = s.Id,
                            Title = s.Title,
                            Description = s.Description,
                            ReleaseDate = s.ReleaseDate,
                            ImageUrl = s.ImageUrl,
                            Rating = Math.Round(s.Ratings.Average(a => a.Score), 1),
                            Actors = s.Actors.Select(x => x.FirstName + " " + x.LastName).ToList()
                        })
                        .OrderByDescending(o => o.Rating)
                        .ToList();
        }
        private async Task<List<VideoDto>> SearchByAfterYear(VideoType videoType, int year)
        {
            return _context.Videos
                        .Where(w => w.Type == videoType &&
                                    w.ReleaseDate.Year > year)
                        .Select(s => new VideoDto
                        {
                            Id = s.Id,
                            Title = s.Title,
                            Description = s.Description,
                            ReleaseDate = s.ReleaseDate,
                            ImageUrl = s.ImageUrl,
                            Rating = Math.Round(s.Ratings.Average(a => a.Score), 1),
                            Actors = s.Actors.Select(x => x.FirstName + " " + x.LastName).ToList()
                        })
                        .OrderByDescending(o => o.Rating)
                        .ToList();
        }

        private async Task<List<VideoDto>> SearchByOlderThanYears(VideoType videoType, int years)
        {
            return _context.Videos
                        .Where(w => w.Type == videoType &&
                                    w.ReleaseDate < DateTime.Now.AddYears(-years))
                        .Select(s => new VideoDto
                        {
                            Id = s.Id,
                            Title = s.Title,
                            Description = s.Description,
                            ReleaseDate = s.ReleaseDate,
                            ImageUrl = s.ImageUrl,
                            Rating = Math.Round(s.Ratings.Average(a => a.Score), 1),
                            Actors = s.Actors.Select(x => x.FirstName + " " + x.LastName).ToList()
                        })
                        .OrderByDescending(o => o.Rating)
                        .ToList();
        }
        public void RateVideo(int id, int score)
        {
            var rating = new Rating()
            {
                VideoId = id,
                Score = score
            };
            _context.Ratings.Add(rating);
            _context.SaveChanges();
        }
        public void BuyTicket(int screeningId, int numberOfTickets)
        {
            var screening = _context.Screenings.FirstOrDefault(x => x.Id == screeningId);
            if (screening == null)
            {
                throw new Exception("Screening doesn't exist.");
            }

            if (screening.AvailableTickets < numberOfTickets)
            {
                throw new Exception("Not enough tickets available.");
            }

            if (screening.DateAndTime < DateTime.Now)
            {
                throw new Exception("You can't buy tickets for past screenings.");
            }

            screening.AvailableTickets = screening.AvailableTickets - numberOfTickets;
            screening.SoldTickets = screening.SoldTickets + numberOfTickets;
            _context.SaveChanges();
        }
        public List<TopTenMoviesByRatings> GetTopTenMoviesByRatings()
        {
            List<TopTenMoviesByRatings> result = _context.TopTenMoviesByRatings
                .FromSqlRaw("EXEC [dbo].[GetTopTenMovies]")
                .ToList();

            return result;
        }
        public List<TopTenMoviesByScreenings> GetTopTenMoviesByScreenings(DateTime startDate, DateTime endDate)
        {
            List<TopTenMoviesByScreenings> result = _context.TopTenMoviesByScreenings
                .FromSqlRaw("EXEC [dbo].[GetTopTenMoviesByScreenings] @StartDate={0}, @EndDate={1}", startDate, endDate)
                .ToList();

            return result;
        }
        public List<TopMoviesByMostSoldTickets> GetTopMoviesByMostSoldTickets()
        {
            List<TopMoviesByMostSoldTickets> result = _context.TopMoviesByMostSoldTickets
                .FromSqlRaw("EXEC [dbo].[GetTopMoviesByMostSoldTickets]")
                .ToList();

            return result;
        }
        public void InsertScreeningData()
        {
            if (_context.Screenings.Any()) return;

            var movies = _context.Videos
                .Where(w => w.Type == VideoType.Movie)
                .ToList();

            foreach (var movie in movies)
            {
                // Add screening for each movie for next 10 days
                for (int day = 0; day < 10; day++)
                {
                    var screeningPerDay = _random.Next(1, 5);
                    // Add up to 5 screenings per day
                    for (int i = 0; i < screeningPerDay; i++)
                    {
                        var screening = new Screening()
                        {
                            Video = movie,
                            DateAndTime = DateTime.Now.Date.AddDays(day),
                            AvailableTickets = 20,
                            SoldTickets = 0
                        };

                        screening.DateAndTime = screening.DateAndTime.AddHours(_random.Next(17, 23));
                        _context.Screenings.Add(screening);
                    }
                }
            }
            _context.SaveChanges();
        }
    }
}
