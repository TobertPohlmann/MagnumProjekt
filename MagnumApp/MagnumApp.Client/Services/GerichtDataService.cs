using Magnum.Model.Nahrung;
using System.Text.Json;

namespace MagnumApp.Client.Services
{
    public class GerichtDataService : IGerichtDataService
    {
        private readonly HttpClient _httpClient = default!;

        public GerichtDataService(HttpClient httpClient) 
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<Gericht>> GetGerichte()
        {
            return await JsonSerializer.DeserializeAsync<IEnumerable<Gericht>>(
                await _httpClient.GetStreamAsync($"api/gericht"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }
    }
}
