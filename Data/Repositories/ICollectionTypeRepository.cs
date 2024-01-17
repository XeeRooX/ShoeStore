using ShoeStore.Models;

namespace ShoeStore.Data.Repositories
{
    public interface ICollectionTypeRepository: IRepository<CollectionType>
    {
        bool IsUniqueName(string name, string shortName);
        bool IsUniqueNameById(string name, string shortName, int id);
    }
}
