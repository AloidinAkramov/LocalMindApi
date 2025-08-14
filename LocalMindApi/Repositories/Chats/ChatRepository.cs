using LocalMindApi.DataContext;
using LocalMindApi.Models.Chats;
using System.Linq;
using System.Threading.Tasks;

namespace LocalMindApi.Repositories.Chats
{
    public class ChatRepository : IChatRepository
    {
        private readonly ApplicationDbContext dbContext;

        public ChatRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async ValueTask<Chat> InsertChatAsync(Chat chat)
        {
            await this.dbContext.Chats.AddAsync(chat);
            await this.dbContext.SaveChangesAsync();

            return chat;
        }

        public IQueryable<Chat> SelectAllChats()
        {
            return this.dbContext.Chats;
        }
    }
}
