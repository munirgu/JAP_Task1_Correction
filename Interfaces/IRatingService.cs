using System.Threading.Tasks;

namespace JAP_Task_Backend.Interfaces
{
   public interface IRatingService
    {
        Task RateVideo(int id, int score);
    }
}
