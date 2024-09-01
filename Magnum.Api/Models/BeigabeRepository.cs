using Magnum.Model.Nahrung.Data;

namespace Magnum.Api.Models
{
    public class BeigabeRepository : IBeigabeRepository
    {
        private readonly GerichtDbContext _dbContext;

        public BeigabeRepository(GerichtDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IEnumerable<BeigabeData> GetBeigabeDataFürNutzer(Guid userId)
        {
            var alleGerichtIds = _dbContext.GerichtData.Where(x => x.UserId == userId).Select(x => x.GerichtId);
            return _dbContext.ZutatenBeigaben.Where(x => alleGerichtIds.Contains(x.GerichtId));
        }
    }
}
