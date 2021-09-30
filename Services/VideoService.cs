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
            var videos =await _context.Videos
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
                .ToListAsync();
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
            return await _context.Videos
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
                        .ToListAsync();
        }

        private async Task<List<VideoDto>> SearchByAtLeastRating(VideoType videoType, int score)
        {
            return await _context.Videos
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
                        .ToListAsync();
        }
        private async Task<List<VideoDto>> SearchByRating(VideoType videoType, int score)
        {
            return await _context.Videos
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
                        .ToListAsync();
        }
        private async Task<List<VideoDto>> SearchByAfterYear(VideoType videoType, int year)
        {
            return await _context.Videos
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
                        .ToListAsync();
        }

        private async Task<List<VideoDto>> SearchByOlderThanYears(VideoType videoType, int years)
        {
            return await _context.Videos
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
                        .ToListAsync();
        }
        public async Task BuyTicket(int screeningId, int numberOfTickets)
        {
            var screening = await _context.Screenings.FirstOrDefaultAsync(x => x.Id == screeningId);

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
            await _context.SaveChangesAsync();
        }
        public  async Task<List<TopTenMoviesByRatings>> GetTopTenMoviesByRatings()
        {
            List<TopTenMoviesByRatings> result =await _context.TopTenMoviesByRatings
                .FromSqlRaw("EXEC [dbo].[GetTopTenMovies]")
                .ToListAsync();

            return result;
        }
        public async Task<List<TopTenMoviesByScreenings>> GetTopTenMoviesByScreenings(DateTime startDate, DateTime endDate)
        {
            List<TopTenMoviesByScreenings> result = await _context.TopTenMoviesByScreenings
                .FromSqlRaw("EXEC [dbo].[GetTopTenMoviesByScreenings] @StartDate={0}, @EndDate={1}", startDate, endDate)
                .ToListAsync();

            return result;
        }
        public async Task<List<TopMoviesByMostSoldTickets>> GetTopMoviesByMostSoldTickets()
        {
            List<TopMoviesByMostSoldTickets> result = await _context.TopMoviesByMostSoldTickets
                .FromSqlRaw("EXEC [dbo].[GetTopMoviesByMostSoldTickets]")
                .ToListAsync();

            return result;
        }
        public async Task InsertScreeningData()
        {
            if (await _context.Screenings.AnyAsync()) return;

            var movies = await _context.Videos
                .Where(w => w.Type == VideoType.Movie)
                .ToListAsync();

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
                        await _context.Screenings.AddAsync(screening);
                    }
                }
            }
            await _context.SaveChangesAsync();
        }
    }
}
