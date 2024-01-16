using ShoeStore.Models;

namespace ShoeStore.Data.Repositories
{
    public interface IColorRepository: IRepository<Color>
    {
        bool IsUniqueName(string name);
        bool IsUniqueNameById(string name, int id);
    }
}
