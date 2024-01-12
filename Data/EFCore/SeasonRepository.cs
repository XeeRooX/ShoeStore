using ShoeStore.Data.Repositories;
using ShoeStore.Models;

namespace ShoeStore.Data.EFCore
{
    public class SeasonRepository : EfCoreRepository<Season, ApplicationDbContext>, ISeasonRepository
    {
        public SeasonRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
