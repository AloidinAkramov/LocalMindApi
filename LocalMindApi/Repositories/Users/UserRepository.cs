using LocalMindApi.DataContext;
using LocalMindApi.Models.Users;
using Microsoft.AspNetCore.CookiePolicy;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace LocalMindApi.Repositories.Users
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext context;

        public UserRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async ValueTask<User> InsertUserAsync(User user)
        {
            await context.Users.AddAsync(user);
            await context.SaveChangesAsync();
            return user;
        }

        public IQueryable<User> SelectAllUsers()
        {
            return context.Users.Include(user => user.UserAdditionalDetail);
        }
    }
}