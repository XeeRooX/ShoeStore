using ShoeStore.Models;

namespace ShoeStore.Data.Repositories
{
    public interface IShoeTypeRepository: IRepository<ShoeType>
    {
        bool IsUniqueName(string name);
        bool IsUniqueNameById(string name, int id);
    }
}
