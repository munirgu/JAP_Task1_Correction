using JAP_Task_Backend.Interfaces;
using JAP_Task_Backend.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace JAP_Task_Backend.Extensions
{
    public class AddScoped
    {
        public static void AddScopedConfiguration(IServiceCollection services)
        {
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped<IVideoService, VideoService>();
            services.AddScoped<IAuthRepository, AuthRepository>();
            services.AddScoped<IRatingService, RatingService>();
        }
    }
}
