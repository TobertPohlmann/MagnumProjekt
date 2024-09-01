using Magnum.Model.Nahrung;
using Magnum.Model.Nahrung.Data;
using Magnum.Api.Models.Data;

namespace Magnum.Api.Models
{
    public class GerichtRepository : IGerichtRepository
    {
        
        private readonly GerichtDbContext _dbContext;

        public GerichtRepository(GerichtDbContext dbContext) 
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Gericht> GetAllGerichteFürNutzer(Guid userId)
        {
            var alleZutaten = _dbContext.ZutatData;
            var alleBeigaben = _dbContext.ZutatenBeigaben;

            var alleGerichte = new List<Gericht>();
            foreach (GerichtData data in _dbContext.GerichtData.Where(x => x.UserId == userId)) 
            {
                alleGerichte.Add(NahrungsDataConverter.ErzeugeGerichtAusDaten(data, alleZutaten, alleBeigaben));                            
            }
            return alleGerichte;
        }
    }
}
