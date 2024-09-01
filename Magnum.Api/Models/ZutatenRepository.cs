using Magnum.Api.Models.Data;
using Magnum.Model.Nahrung;
using Magnum.Model.Nahrung.Data;

namespace Magnum.Api.Models
{
    public class ZutatenRepository : IZutatenRepository
    {
        private readonly GerichtDbContext _dbContext;

        public ZutatenRepository(GerichtDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Zutat> GetAllZutatenFürNutzer(Guid userId)
        {
            var alleZutaten = new List<Zutat>();
            foreach(ZutatData data in _dbContext.ZutatData.Where(x => x.UserId == userId))
            {
                alleZutaten.Add(NahrungsDataConverter.ErzeugeZutatAusDaten(data));
            }
            return alleZutaten;
        }
    }
}
