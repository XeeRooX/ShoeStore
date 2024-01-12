using ShoeStore.Data.Repositories;
using ShoeStore.Models;

namespace ShoeStore.Data.EFCore
{
    public class ColorRepository : EfCoreRepository<Color, ApplicationDbContext>, IColorRepository<Color>
    {
        public ColorRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
