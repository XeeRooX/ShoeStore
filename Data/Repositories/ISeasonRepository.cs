using ShoeStore.Models;

namespace ShoeStore.Data.Repositories
{
    public interface ISeasonRepository : IRepository<Season>
    {
        bool IsUniqueName(string name);
        bool IsUniqueNameById(string name, int id);
    }
}
