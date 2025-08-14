using LocalMindApi.Models.ChatDetails;
using LocalMindApi.Services.ChatDetails;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Security.Claims;
using System.Threading.Tasks;

namespace LocalMindApi.Controllers
{
    [ApiController]
    [Route("api/chat-details")]
    public class ChatDetailsController : ControllerBase
    {
        private readonly IChatDetailService chatDetailService;

        public ChatDetailsController(IChatDetailService chatDetailService)
        {
            this.chatDetailService = chatDetailService;
        }

        [HttpPost]
        public async ValueTask<ActionResult<ChatDetail>> PostChatDetailAsync(ChatDetail chatDetail)
        {

            Guid userId = Guid.Parse(this.User.FindFirstValue(ClaimTypes.NameIdentifier));

            ChatDetail newChatDetail =
                await this.chatDetailService.AddChatDetailsAsync(chatDetail , userId);

            return StatusCode(201, newChatDetail);
        }
    }
}
