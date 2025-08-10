using LocalMindApi.Models.UserCredentials;
using LocalMindApi.Models.UserTokens;
using System.Threading.Tasks;

namespace LocalMindApi.Services.Accounts
{
    public interface IAccountService
    {
        ValueTask<UserToken> LoginAsync(UserCredential userCredentials);
    }
}