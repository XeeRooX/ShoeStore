using ShoeStore.Data;

namespace ShoeStore.Models
{
    public class CollectionType : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string ShortName { get; set; } = null!;
        public List<Shoe> Shoes { get; set; } = new();
    }
}
