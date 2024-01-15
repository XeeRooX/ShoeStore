using Microsoft.EntityFrameworkCore;
using ShoeStore.Data.Repositories;
using ShoeStore.Models;

namespace ShoeStore.Data.EFCore
{
    public class ShoeRepository : EfCoreRepository<Shoe, ApplicationDbContext>, IShoeRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public ShoeRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Shoe> GetIncludedAsync(int id)
        {
            var result = (await _dbContext.Shoes.
                Include(s => s.Size).
                Include(s => s.CollectionType).
                Include(s => s.ShoeType).
                Include(s => s.Season).
                Include(s => s.Color).
                Include(s => s.Model).ThenInclude(m => m.Brand).
                FirstOrDefaultAsync(s => s.Id == id))!;

            return result;
        }

        public async Task<IEnumerable<Shoe>> GetAllIncludedAsync()
        {
            var result = (await _dbContext.Shoes.
                Include(s => s.Size).
                Include(s => s.CollectionType).
                Include(s => s.ShoeType).
                Include(s => s.Season).
                Include(s => s.Color).
                Include(s => s.Model).ThenInclude(m => m.Brand).
                ToListAsync())!;

            return result;
        }

        public async Task<Shoe> DeleteIncludedAsync(int id)
        {
            var shoes = (await _dbContext.Shoes.
                Include(s => s.Size).
                Include(s => s.CollectionType).
                Include(s => s.ShoeType).
                Include(s => s.Season).
                Include(s => s.Color).
                Include(s => s.Model).ThenInclude(m => m.Brand).
                FirstOrDefaultAsync(s => s.Id == id))!;

            _dbContext.Shoes.Remove(shoes);
            await _dbContext.SaveChangesAsync();

            return shoes;
        }
    }
}
