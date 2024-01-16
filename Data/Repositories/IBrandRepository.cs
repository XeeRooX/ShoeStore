using ShoeStore.Models;

namespace ShoeStore.Data.Repositories
{
    public interface IBrandRepository : IRepository<Brand>
    {
        bool IsUniqueName(string name);
        bool IsUniqueNameById(string name, int id);
    }
}
