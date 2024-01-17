using Microsoft.EntityFrameworkCore;

namespace ShoeStore.Data.EFCore
{
    public abstract class EfCoreRepository<TEntity, TContext> : IRepository<TEntity>
        where TEntity : class, IEntity
        where TContext : DbContext
    {
        private readonly TContext _dbContext;

        public EfCoreRepository(TContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<TEntity> AddAsync(TEntity entity)
        {
            _dbContext.Set<TEntity>().Add(entity);
            await _dbContext.SaveChangesAsync();

            return entity;
        }

        public async Task<TEntity> DeleteAsync(int id)
        {
            var entity = (await _dbContext.Set<TEntity>().FindAsync(id))!;
            _dbContext.Remove(entity);
            await _dbContext.SaveChangesAsync();

            return entity;
        }

        public TEntity Get(int id)
        {
            return _dbContext.Set<TEntity>().Find(id)!;
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _dbContext.Set<TEntity>().ToListAsync();
        }

        public async Task<TEntity> GetAsync(int id)
        {
            return (await _dbContext.Set<TEntity>().FindAsync(id))!;
        }

        public bool IsExistsById(int id)
        {
            return _dbContext.Set<TEntity>().Find(id) != null;
        }

        public async Task<TEntity> UpdateAsync(TEntity entity)
        {
            var existingEntity = _dbContext.Set<TEntity>().Local.FirstOrDefault(x => x.Id == entity.Id);
            if (existingEntity != null)
            {
                _dbContext.Set<TEntity>().Local.Clear();
            }
            _dbContext.Entry(entity).State = EntityState.Modified;

            await _dbContext.SaveChangesAsync();
            return entity;
        }
    }
}
