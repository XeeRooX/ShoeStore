using Microsoft.EntityFrameworkCore;
using ShoeStore.Data.Repositories;
using ShoeStore.Models;

namespace ShoeStore.Data.EFCore
{
    public class ShoeTypeRepository : EfCoreRepository<ShoeType, ApplicationDbContext>, IShoeTypeRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public ShoeTypeRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public bool IsUniqueName(string name)
        {
            return _dbContext.ShoeTypes.FirstOrDefault(c => c.Name == name) == null;
        }

        public bool IsUniqueNameById(string name, int id)
        {
            var shoeType = _dbContext.ShoeTypes.FirstOrDefault(c => c.Name == name);
            return shoeType != null ? shoeType.Id == id : true;
        }
    }
}
