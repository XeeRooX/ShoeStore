using ShoeStore.Data;

namespace ShoeStore.Models
{
    public class Brand : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
    }
}
