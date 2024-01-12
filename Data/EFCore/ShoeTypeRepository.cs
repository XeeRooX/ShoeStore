using ShoeStore.Data.Repositories;
using ShoeStore.Models;

namespace ShoeStore.Data.EFCore
{
    public class ShoeTypeRepository : EfCoreRepository<ShoeType, ApplicationDbContext>, IShoeTypeRepository<ShoeType>
    {
        public ShoeTypeRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
