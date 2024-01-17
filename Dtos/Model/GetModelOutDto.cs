namespace ShoeStore.Dtos.Model
{
    public class GetModelOutDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int BrandId { get; set; }
        public string Brand { get; set;} = null!;
    }
}
