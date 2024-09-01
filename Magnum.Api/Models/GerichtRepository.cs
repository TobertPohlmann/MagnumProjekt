using Magnum.Model.Nahrung;
using Magnum.Model.Nahrung.Data;

namespace Magnum.Api.Models
{
    public class GerichtRepository : IGerichtRepository
    {
        
        private readonly GerichtDbContext _dbContext;

        public GerichtRepository(GerichtDbContext dbContext) 
        {
            _dbContext = dbContext;
        }

        public IEnumerable<GerichtData> GetAllGerichtDataFürNutzer(Guid userId)
        {
            return _dbContext.GerichtData;
        }
    }
}
