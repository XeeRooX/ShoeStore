namespace ShoeStore.Dtos.Shoe
{
    public class AddShoesDto
    {
        public double Price { get; set; }
        public int ColorId { get; set; }
        public int ModelId { get; set; }
        public int SeasonId { get; set; }
        public int ShoeTypeId { get; set; }
        public int CollectionTypeId { get; set; }
        public int SizeId { get; set; }
    }
}
