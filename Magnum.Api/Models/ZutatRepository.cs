using Magnum.Model.Nahrung.Data;

namespace Magnum.Api.Models
{
    public class ZutatRepository : IZutatRepository
    {
        private readonly GerichtDbContext _dbContext;

        public ZutatRepository(GerichtDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<ZutatData> GetZutatDataFürNutzer(Guid userId)
        {
            return _dbContext.ZutatData.Where(x => x.UserId == userId);
        }
    }
}
