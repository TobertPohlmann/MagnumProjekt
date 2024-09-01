using Magnum.Model.Nahrung;
using Magnum.Model.Nahrung.Data;

namespace Magnum.Api.Models
{
    public interface IZutatenRepository
    {
        IEnumerable<Zutat> GetAllZutatenFürNutzer(Guid guid);
    }
}
