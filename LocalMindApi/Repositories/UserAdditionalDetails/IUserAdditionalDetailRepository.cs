using LocalMindApi.Models.UserAdditionalDetails;
using System.Threading.Tasks;

namespace LocalMindApi.Repositories.UserAdditionalDetails
{
    public interface IUserAdditionalDetailRepository 
    {
        ValueTask<UserAdditionalDetail> InsertUserAdditionalDetailAsync(
            UserAdditionalDetail userAdditionalDetail);
    }
}
