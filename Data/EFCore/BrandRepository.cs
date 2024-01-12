using ShoeStore.Data.Repositories;
using ShoeStore.Models;

namespace ShoeStore.Data.EFCore
{
    public class BrandRepository : EfCoreRepository<Brand, ApplicationDbContext>, IBrandRepository<Brand>
    {
        public BrandRepository(ApplicationDbContext dbContext) : base(dbContext)
        {   
        }

    }
}
