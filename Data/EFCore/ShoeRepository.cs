using ShoeStore.Data.Repositories;
using ShoeStore.Models;

namespace ShoeStore.Data.EFCore
{
    public class ShoeRepository : EfCoreRepository<Shoe, ApplicationDbContext>, IShoeRepository<Shoe>
    {
        public ShoeRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
