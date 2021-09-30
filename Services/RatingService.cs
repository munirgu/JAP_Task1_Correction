using JAP_Task_Backend.Database;
using JAP_Task_Backend.Interfaces;
using JAP_Task_Backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
