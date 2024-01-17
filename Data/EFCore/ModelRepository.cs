using Microsoft.EntityFrameworkCore;
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

        public async Task<Model> DeleteIncludedAsync(int id)
        {
            var model = (await _dbContext.Models.Include(m => m.Brand).FirstOrDefaultAsync(m => m.Id == id))!;
            _dbContext.Models.Remove(model);
            await _dbContext.SaveChangesAsync();
            return model;
        }

        public async Task<IEnumerable<Model>> GetAllIncludedAsync()
        {
            var result = await _dbContext.Models.Include(m => m.Brand).ToListAsync();
            return result;
        }

        public async Task<Model> GetIncludedAsync(int id)
        {
            var result = (await _dbContext.Models.Include(m => m.Brand).FirstOrDefaultAsync(m => m.Id == id))!;
            return result;
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
