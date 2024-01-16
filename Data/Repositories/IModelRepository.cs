using ShoeStore.Models;

namespace ShoeStore.Data.Repositories
{
    public interface IModelRepository: IRepository<Model>
    {
        bool IsUniqueName(string name);
        bool IsUniqueNameById(string name, int id);
    }
}
