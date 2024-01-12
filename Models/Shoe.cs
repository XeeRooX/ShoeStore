using ShoeStore.Data;

namespace ShoeStore.Models
{
    public class Shoe : IEntity
    {
        public int Id { get; set; }

        public int ColorId { get; set; }
        public Color Color { get; set; } = null!;
        public int ModelId { get; set; }
        public Model Model { get; set; } = null!;
        public int SeasonId { get; set; }
        public Season Season { get; set; } = null!;
        public int ShoeTypeId { get; set; }
        public ShoeType ShoeType { get; set; } = null!;
        public int CollectionTypeId { get; set; }
        public CollectionType CollectionType { get; set; } = null!;
        public int SizeId { get; set; }
        public Size Size { get; set; } = null!;
    }
}
