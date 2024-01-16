using ShoeStore.Data.Repositories;
using ShoeStore.Models;

namespace ShoeStore.Data.EFCore
{
    public class BrandRepository : EfCoreRepository<Brand, ApplicationDbContext>, IBrandRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public BrandRepository(ApplicationDbContext dbContext) : base(dbContext)
        {   
            _dbContext = dbContext;
        }

        public bool IsUniqueName(string name)
        {
            return _dbContext.Brands.FirstOrDefault(c => c.Name == name) == null;
        }

        public bool IsUniqueNameById(string name, int id)
        {
            var brand = _dbContext.Brands.FirstOrDefault(c => c.Name == name);
            return brand != null ? brand.Id == id : true;
        }
    }
}
