using ShoeStore.Data.Repositories;
using ShoeStore.Models;

namespace ShoeStore.Data.EFCore
{
    public class ModelRepository : EfCoreRepository<Model, ApplicationDbContext>, IModelRepository<Model>
    {
        public ModelRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
