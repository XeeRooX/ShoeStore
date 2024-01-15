using ShoeStore.Data;

namespace ShoeStore.Models
{
    public class Brand : IEntity, IDirectory
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
    }
}
