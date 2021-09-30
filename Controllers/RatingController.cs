using JAP_Task_Backend.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace JAP_Task_Backend.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/videos")]
    public class RatingController : Controller
    {
        private readonly IRatingService _ratingService;
        public RatingController(IRatingService ratingService)
        {
            _ratingService = ratingService;
        }

        [HttpPost("rate-video")]
        public async Task<IActionResult> RateVideo(int id, int score)
        {
            await _ratingService.RateVideo(id, score);
            return Ok();
        }
    }
}
