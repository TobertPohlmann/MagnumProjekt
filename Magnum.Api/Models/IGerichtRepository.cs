using Magnum.Model.Nahrung;

namespace Magnum.Api.Models
{
    public interface IGerichtRepository
    {
        IEnumerable<Gericht> GetAllGerichteFürNutzer(Guid userId);
    }
}
