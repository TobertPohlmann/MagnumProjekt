using Magnum.Model.Nahrung;
using Magnum.Model.Nahrung.Data;

namespace Magnum.Shared.Services
{
    public interface IGerichtDataService
    {
        Task<IEnumerable<GerichtData>> GetGerichte();
    }
}
