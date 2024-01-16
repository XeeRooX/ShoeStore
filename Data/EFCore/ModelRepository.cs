using ShoeStore.Data.Repositories;
using ShoeStore.Models;

namespace ShoeStore.Data.EFCore
{
    public class ModelRepository : EfCoreRepository<Model, ApplicationDbContext>, IModelRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public ModelRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public bool IsUniqueName(string name)
        {
            return _dbContext.Models.FirstOrDefault(c => c.Name == name) == null;
        }

        public bool IsUniqueNameById(string name, int id)
        {
            var model = _dbContext.Models.FirstOrDefault(c => c.Name == name);
            return model != null ? model.Id == id : true;
        }
    }
}
