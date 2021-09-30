using JAP_Task_Backend.Database;
using JAP_Task_Backend.Interfaces;
using JAP_Task_Backend.Models;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;
using System.Threading.Tasks;

namespace JAP_Task_Backend.Services
{
    public class RatingService : IRatingService
    {
        private readonly ApplicationDbContext _context;
        private readonly IHttpContextAccessor _httpContextAccessor;

        private int GetUserId() => int.Parse(_httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier));

        public RatingService(ApplicationDbContext context, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task RateVideo(int id, int score)
        {
            var rating = new Rating()
            {
                VideoId = id,
                Score = score,
                UserId = GetUserId()
            };
           await _context.Ratings.AddAsync(rating);
           await _context.SaveChangesAsync();
        }
    }
}
