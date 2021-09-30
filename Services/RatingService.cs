using JAP_Task_Backend.Database;
using JAP_Task_Backend.Interfaces;
using JAP_Task_Backend.Models;
using System.Threading.Tasks;

namespace JAP_Task_Backend.Services
{
    public class RatingService : IRatingService
    {
        private readonly ApplicationDbContext _context;
        public RatingService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task RateVideo(int id, int score)
        {
            var rating = new Rating()
            {
                VideoId = id,
                Score = score
            };
           await _context.Ratings.AddAsync(rating);
           await _context.SaveChangesAsync();
        }
    }
}
