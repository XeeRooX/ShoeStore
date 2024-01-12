namespace ShoeStore.Models
{
    public class Size
    {
        public int Id { get; set; }
        public double Number { get; set; }
        public List<Shoe> Shoes { get; set; } = new();
    }
}
