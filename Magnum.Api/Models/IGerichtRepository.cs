using Magnum.Model.Nahrung;
using Magnum.Model.Nahrung.Data;

namespace Magnum.Api.Models
{
    public interface IGerichtRepository
    {
        IEnumerable<GerichtData> GetAllGerichtDataFürNutzer(Guid userId);
    }
}
