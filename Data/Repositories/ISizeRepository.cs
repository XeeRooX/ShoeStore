using ShoeStore.Models;

namespace ShoeStore.Data.Repositories
{
    public interface ISizeRepository: IRepository<Size>
    {
        bool IsUniqueSize(double size);
        bool IsUniqueSizeById(double size, int id);
    }
}
