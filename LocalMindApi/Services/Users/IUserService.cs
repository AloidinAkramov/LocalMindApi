using LocalMindApi.DTOs;
using LocalMindApi.Models.Users;
using System.Linq;
using System.Threading.Tasks;

namespace LocalMindApi.Services.Users
{
    public interface IUserService
    {
        ValueTask<UserDto> AddUserAsync(UserDto userDto);
        IQueryable<UserDto> RetrieveAllUsers();
    }
}
