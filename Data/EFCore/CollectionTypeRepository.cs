using ShoeStore.Data.Repositories;
using ShoeStore.Models;

namespace ShoeStore.Data.EFCore
{
    public class CollectionTypeRepository : EfCoreRepository<CollectionType, ApplicationDbContext>, 
        ICollectionTypeRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public CollectionTypeRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public bool IsUniqueName(string name, string shortName)
        {
            return (_dbContext.CollectionTypes.FirstOrDefault(c => c.Name == name) == null &&
                _dbContext.CollectionTypes.FirstOrDefault(c => c.ShortName == shortName) == null);
        }

        public bool IsUniqueNameById(string name, string shortName, int id)
        {
            var Name = _dbContext.CollectionTypes.FirstOrDefault(c => c.Name == name);
            var ShortName = _dbContext.CollectionTypes.FirstOrDefault(c => c.ShortName == shortName);
            return (Name != null && ShortName != null) ? (Name.Id == id) && Name.Id == ShortName.Id : (Name == null && ShortName == null);
        }
    }
}
