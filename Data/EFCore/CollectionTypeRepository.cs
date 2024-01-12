using ShoeStore.Data.Repositories;
using ShoeStore.Models;

namespace ShoeStore.Data.EFCore
{
    public class CollectionTypeRepository : EfCoreRepository<CollectionType, ApplicationDbContext>, 
        ICollectionTypeRepository<CollectionType>
    {
        public CollectionTypeRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
