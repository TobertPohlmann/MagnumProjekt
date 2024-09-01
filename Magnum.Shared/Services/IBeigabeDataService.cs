using Magnum.Model.Nahrung.Data;

namespace Magnum.Shared.Services
{
    public interface IBeigabeDataService
    {
        Task<IEnumerable<BeigabeData>> GetBeigaben();
    }
}
