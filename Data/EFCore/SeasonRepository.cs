using ShoeStore.Data.Repositories;
using ShoeStore.Models;

namespace ShoeStore.Data.EFCore
{
    public class SeasonRepository : EfCoreRepository<Season, ApplicationDbContext>, ISeasonRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public SeasonRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public bool IsUniqueName(string name)
        {
            return _dbContext.Seasons.FirstOrDefault(c => c.Name == name) == null;
        }

        public bool IsUniqueNameById(string name, int id)
        {
            var season = _dbContext.Seasons.FirstOrDefault(c => c.Name == name);
            return season != null ? season.Id == id : true;
        }
    }
}
