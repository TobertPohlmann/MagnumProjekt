using Magnum.Model.Nahrung.Data;

namespace Magnum.Api.Models
{
    public interface IBeigabeRepository
    {
        IEnumerable<BeigabeData> GetBeigabeDataFürNutzer(Guid userId);
    }
}
