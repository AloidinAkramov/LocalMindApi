using LocalMindApi.Models.Chats;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace LocalMindApi.Services.Chats
{
    public interface IChatService
    {
        IQueryable<Chat> RetrieveAllChatsByUserId(Guid userId);
        ValueTask<Chat> RetrieveChatWithChatDetailsByChatIdAsync(Guid chatId);
    }
}
