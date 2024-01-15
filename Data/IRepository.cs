namespace ShoeStore.Data
{
    public interface IRepository <T> where T : class, IEntity
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetAsync(int id);
        T Get(int id);
        bool IsExistsById(int id);
        Task<T> AddAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task<T> DeleteAsync(int id);

    }
}
