using LocalMindApi.Models.ChatDetails;
using System.Linq;
using System.Threading.Tasks;

namespace LocalMindApi.Repositories.ChatDetails
{
    public interface IChatDetailRepository
    {
        ValueTask<ChatDetail> InsertChatDetailAsync(ChatDetail chatDetail);
        IQueryable<ChatDetail> SelectAllChatDetails();
        ValueTask<ChatDetail> UpdateChatDetailAsync(ChatDetail chatDetail);
    }
}
