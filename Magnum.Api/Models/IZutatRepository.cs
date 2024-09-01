using Magnum.Model.Nahrung;
using Magnum.Model.Nahrung.Data;

namespace Magnum.Api.Models
{
    public interface IZutatRepository
    {
        IEnumerable<ZutatData> GetZutatDataFürNutzer(Guid guid);
    }
}
