using Magnum.Model.Nahrung;
using System.Text.Json;

namespace MagnumApp.Client.Services
{
    public class ZutatenDataService : IZutatenDataService
    {
        private readonly HttpClient _httpClient = default!;

        public ZutatenDataService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<Zutat>> GetZutaten()
        {
            return await JsonSerializer.DeserializeAsync<IEnumerable<Zutat>>(
                 await _httpClient.GetStreamAsync($"api/zutat"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }
    }
}
