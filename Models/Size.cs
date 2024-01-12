using ShoeStore.Data;

namespace ShoeStore.Models
{
    public class Size : IEntity
    {
        public int Id { get; set; }
        public double Number { get; set; }
        public List<Shoe> Shoes { get; set; } = new();
    }
}
