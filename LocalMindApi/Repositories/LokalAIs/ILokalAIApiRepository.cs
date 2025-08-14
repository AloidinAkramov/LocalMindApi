using LocalMindApi.Models.LocalAIs;
using System.Threading.Tasks;

namespace LocalMindApi.Repositories.LokalAIs
{
    public interface ILokalAIApiRepository
    {
        ValueTask<LocalAIResponse> PostLocalAIRequestAsync(LocalAIRequest localAIRequest);
    }
}
