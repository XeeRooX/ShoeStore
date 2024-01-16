using ShoeStore.Data.Repositories;
using ShoeStore.Models;

namespace ShoeStore.Data.EFCore
{
    public class ColorRepository : EfCoreRepository<Color, ApplicationDbContext>, IColorRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public ColorRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public bool IsUniqueName(string name)
        {
            return _dbContext.Colors.FirstOrDefault(c => c.Name == name) == null;
        }

        public bool IsUniqueNameById(string name, int id)
        {
            var color = _dbContext.Colors.FirstOrDefault(c => c.Name == name);
            return color != null ? color.Id == id : true;
        }
    }
}
