using Magnum.Model.Nahrung.Data;
using System.Text.Json;

namespace Magnum.Shared.Services
{
    public class BeigabeDataService : IBeigabeDataService
    {
        private readonly HttpClient _httpClient = default!;

        public BeigabeDataService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<BeigabeData>> GetBeigaben()
        {
            return await JsonSerializer.DeserializeAsync<IEnumerable<BeigabeData>>(
                await _httpClient.GetStreamAsync($"api/beigabe"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }
    }
}
