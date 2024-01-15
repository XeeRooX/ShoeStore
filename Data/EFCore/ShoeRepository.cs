using Microsoft.EntityFrameworkCore;
using ShoeStore.Data.Repositories;
using ShoeStore.Dtos.Shoe;
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

        public async Task<IEnumerable<Shoe>> FilterIncludedAsync(FilterShoesDto filter)
        {
            IQueryable<Shoe> shoes = _dbContext.Shoes.
                Include(s => s.Size).
                Include(s => s.CollectionType).
                Include(s => s.ShoeType).
                Include(s => s.Season).
                Include(s => s.Color).
                Include(s => s.Model).ThenInclude(m => m.Brand);

            shoes = filter.SortByDescending ? shoes.OrderByDescending(s => s.Price) : shoes.OrderBy(s => s.Price);
            shoes = filter.ColorId != 0 ? shoes.Where(s => s.ColorId == filter.ColorId) : shoes;
            shoes = filter.SizeId != 0 ? shoes.Where(s => s.SizeId == filter.SizeId) : shoes;
            shoes = filter.SeasonId != 0 ? shoes.Where(s => s.SeasonId == filter.SeasonId) : shoes;
            shoes = filter.ShoeTypeId != 0 ? shoes.Where(s => s.ShoeTypeId == filter.ShoeTypeId) : shoes;
            shoes = filter.CollectionTypeId != 0 ? shoes.Where(s => s.ShoeTypeId == filter.CollectionTypeId) : shoes;
            shoes = filter.BrandId != 0 ? shoes.Where(s => s.Model.BrandId == filter.BrandId) : shoes;

            if (filter.PriceFrom != 0 || filter.PriceTo != 0)
            {
                shoes = filter.PriceTo == 0 ? shoes.Where(s => s.Price >= filter.PriceFrom) :
                shoes.Where(s => s.Price >= filter.PriceFrom && s.Price <= filter.PriceTo);
            }

            int countPages = (int)Math.Ceiling((double)await shoes.CountAsync() / (double)filter.Count);
            shoes = shoes.Skip((filter.Page - 1) * filter.Count).Take(filter.Count);

            return await shoes.ToListAsync();
        }
    }
}
