using ShoeStore.Models;

namespace ShoeStore.Dtos.Shoe
{
    public class GetShoeFullDto
    {
        public int Id { get; set; }
        public int ColorId { get; set; }
        public string Color { get; set; } = null!;
        public int ModelId { get; set; }
        public string Model { get; set; } = null!;
        public int BrandId { get; set; }
        public string Brand { get; set; } = null!;
        public int SeasonId { get; set; }
        public string Season { get; set; } = null!;
        public int ShoeTypeId { get; set; }
        public string ShoeType { get; set; } = null!;
        public int CollectionTypeId { get; set; }
        public string CollectionType { get; set; } = null!;
        public int SizeId { get; set; }
        public double Size { get; set; }
    }
}
