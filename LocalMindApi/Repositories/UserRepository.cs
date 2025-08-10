using LocalMindApi.DataContext;
using LocalMindApi.Models.Users;
using Microsoft.AspNetCore.CookiePolicy;
using System.Linq;
using System.Threading.Tasks;

namespace LocalMindApi.Repositories
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
            await this.context.Users.AddAsync(user);
            await this.context.SaveChangesAsync();
            return user;
        }

        public IQueryable<User> SelectAllUsers()
        {
            return this.context.Users;
        }
    }
}