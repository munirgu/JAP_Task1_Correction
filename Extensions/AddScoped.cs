using JAP_Task_Backend.Interfaces;
using JAP_Task_Backend.Services;
using Microsoft.Extensions.DependencyInjection;

namespace JAP_Task_Backend.Extensions
{
    public class AddScoped
    {
        public static void AddScopedConfiguration(IServiceCollection services)
        {
            services.AddScoped<IVideoService, VideoService>();
            services.AddScoped<IAuthRepository, AuthRepository>();
            services.AddScoped<IRatingService, RatingService>();
        }
    }
}
