using ShoeStore.Models;

namespace ShoeStore.Data.Repositories
{
    public interface IShoeRepository : IRepository<Shoe>
    {
        Task<IEnumerable<Shoe>> GetAllIncludedAsync();
        Task<Shoe> GetIncludedAsync(int id);
        Task<Shoe> DeleteIncludedAsync(int id);
    }
}
