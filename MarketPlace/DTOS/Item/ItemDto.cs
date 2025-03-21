namespace MarketPlace.Dtos.Item
{
    public class ItemDto
    {
        public int Id { get; set; }
        public double Price { get; set; }
        public string Name { get; set; } = String.Empty;
    }
}