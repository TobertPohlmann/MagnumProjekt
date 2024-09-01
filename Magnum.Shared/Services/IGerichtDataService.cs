using Magnum.Model.Nahrung;

namespace MagnumApp.Client.Services
{
    public interface IGerichtDataService
    {
        Task<IEnumerable<Gericht>> GetGerichte();
    }
}
