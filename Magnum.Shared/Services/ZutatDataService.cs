using Magnum.Model.Nahrung;
using Magnum.Model.Nahrung.Data;
using System.Text.Json;

namespace Magnum.Shared.Services
{
    public class ZutatDataService : IZutatDataService
    {
        private readonly HttpClient _httpClient = default!;

        public ZutatDataService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<ZutatData>> GetZutaten()
        {
            return await JsonSerializer.DeserializeAsync<IEnumerable<ZutatData>>(
                 await _httpClient.GetStreamAsync($"api/zutat"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }
    }
}
