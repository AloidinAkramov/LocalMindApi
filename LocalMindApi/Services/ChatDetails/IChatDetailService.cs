using LocalMindApi.Models.ChatDetails;
using System;
using System.Threading.Tasks;

namespace LocalMindApi.Services.ChatDetails
{
    public interface IChatDetailService
    {
        ValueTask<ChatDetail> AddChatDetailsAsync(ChatDetail chatDetail, Guid userId);
    }
}
