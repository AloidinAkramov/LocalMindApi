using LocalMindApi.Models.LocalAIs;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace LocalMindApi.Repositories.LokalAIs
{
    public class LokalAIApiRepository : ILokalAIApiRepository
    {
        public async ValueTask<LocalAIResponse> PostLocalAIRequestAsync(LocalAIRequest localAIRequest)
        {
            using var httpClient = new HttpClient();
            string jsonBody = JsonSerializer.Serialize(localAIRequest);
            var content = new StringContent(jsonBody, Encoding.UTF8,   "application/json");

            var response = await httpClient.PostAsync("http://localhost:11434/api/generate", content);

            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();

            return JsonSerializer.Deserialize<LocalAIResponse>(responseBody , new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true

            });
        }
    }
}
