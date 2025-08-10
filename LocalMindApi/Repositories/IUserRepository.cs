using LocalMindApi.Models.Users;
using System.Linq;
using System.Threading.Tasks;

namespace LocalMindApi.Repositories
{
    public interface IUserRepository
    {
        ValueTask<User> InsertUserAsync(User user);
        IQueryable<User> SelectAllUsers();
    }
}
