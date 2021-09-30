using JAP_Task_Backend.Entities;
using System.Threading.Tasks;

namespace JAP_Task_Backend.Interfaces
{
    public interface IAuthRepository
    {
        Task<int> Register(User user, string password);
        Task<string> Login(string username, string password);
        Task<bool> UserExists(string username);
    }
}
