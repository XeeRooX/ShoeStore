namespace ShoeStore.Models
{
    public class Model
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public List<Shoe> Shoes { get; set; } = new();
        public int BrandId { get; set; }
        public Brand Brand { get; set; } = null!;
    }
}
