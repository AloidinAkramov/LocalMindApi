using LocalMindApi.Models.Users;
using System.Linq;
using System.Threading.Tasks;

namespace LocalMindApi.Services.Users
{
    public interface IUserService
    {
        ValueTask<User> AddUserAsync(User user);
        IQueryable<User> RetrieveAllUsers();
    }
}
