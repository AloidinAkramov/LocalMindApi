using LocalMindApi.Models.Chats;
using System.Linq;
using System.Threading.Tasks;

namespace LocalMindApi.Repositories.Chats
{
    public interface IChatRepository
    {
        ValueTask<Chat> InsertChatAsync(Chat chat);
        IQueryable<Chat> SelectAllChats();
    }
}
