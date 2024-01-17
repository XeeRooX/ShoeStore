namespace ShoeStore.Dtos.Model
{
    public class EditModelDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int BrandId { get; set; }
    }
}
