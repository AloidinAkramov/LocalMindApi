using LocalMindApi.DataContext;
using LocalMindApi.Models.UserAdditionalDetails;
using System.Threading.Tasks;

namespace LocalMindApi.Repositories.UserAdditionalDetails
{
    public class UserAdditionalDetailRepository : IUserAdditionalDetailRepository
    {
        private readonly ApplicationDbContext applicationDbContext;

        public UserAdditionalDetailRepository(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }

        public async ValueTask<UserAdditionalDetail> InsertUserAdditionalDetailAsync(
            UserAdditionalDetail userAdditionalDetail)
        {
            this.applicationDbContext.UserAdditionalDetails.AddAsync(userAdditionalDetail);

            return userAdditionalDetail;
        }
    }
}
