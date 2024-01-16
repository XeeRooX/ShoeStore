using ShoeStore.Data.Repositories;
using ShoeStore.Models;
using System.Xml.Linq;

namespace ShoeStore.Data.EFCore
{
    public class SizeRepository : EfCoreRepository<Size, ApplicationDbContext>, ISizeRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public SizeRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public bool IsUniqueSize(double size)
        {
            return _dbContext.Sizes.FirstOrDefault(c => c.Number == size) == null;
        }

        public bool IsUniqueSizeById(double size, int id)
        {
            var sizeRes = _dbContext.Sizes.FirstOrDefault(c => c.Number == size);
            return sizeRes != null ? sizeRes.Id == id : true;
        }
    }
}
