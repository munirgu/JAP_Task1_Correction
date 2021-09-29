using JAP_Task_Backend.Interfaces;
using Microsoft.AspNetCore.Mvc;

using System.Threading.Tasks;
using JAP_Task_Backend.DTO;
using JAP_Task_Backend.Entities;

namespace JAP_Task_Backend.Controllers
{

    [ApiController]
    [Route("Auth")]
    public class AuthController : Controller
    {
        private readonly IAuthRepository _authRepo;

         public AuthController (IAuthRepository authRepo)
        {
            _authRepo = authRepo;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(UserRegisterDto request)
        {
            var response = await _authRepo.Register(
                new User { Username = request.Username }, request.Password
                );

            return Ok(response);
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(UserLoginDto request)
        {
            var response = await _authRepo.Login(
                request.Username, request.Password
                );
            return Ok(response);
        }
    }
}