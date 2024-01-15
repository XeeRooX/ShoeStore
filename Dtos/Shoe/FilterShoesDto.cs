namespace ShoeStore.Dtos.Shoe
{
    public class FilterShoesDto
    {
        public int ColorId { get; set; }
        public int BrandId { get; set; }
        public int SeasonId { get; set; }
        public int ShoeTypeId { get; set; }
        public int CollectionTypeId { get; set; }
        public int SizeId { get; set; }

        public int Page { get; set; }
        public int Count { get; set; }
        public bool SortByDescending { get; set; }
        public double PriceFrom { get; set; }
        public double PriceTo { get; set; }
    }
}
