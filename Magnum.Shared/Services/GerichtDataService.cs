using Magnum.Model.Nahrung.Data;
using System.Text.Json;

namespace Magnum.Shared.Services
{
    public class GerichtDataService : IGerichtDataService
    {
        private readonly HttpClient _httpClient = default!;

        public GerichtDataService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<GerichtData>> GetGerichte()
        {
            var response = await _httpClient.GetStreamAsync($"api/Gericht");
            var gerichtData = await JsonSerializer.DeserializeAsync<IEnumerable<GerichtData>>(
                response, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });

            return gerichtData;
        }
    }
}
