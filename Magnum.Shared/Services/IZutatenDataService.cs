using Magnum.Model.Nahrung;

namespace MagnumApp.Client.Services
{
    public interface IZutatenDataService
    {
        Task<IEnumerable<Zutat>> GetZutaten();
    }
}
