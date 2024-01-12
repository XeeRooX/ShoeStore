namespace ShoeStore.Models
{
    public class Season
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public List<Shoe> Shoes { get; set; } = new();
    }
}
