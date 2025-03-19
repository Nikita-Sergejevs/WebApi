namespace MarketPlace.Models
{
    public class Item
    {
        public int Id { get; set; }
        public double Cost { get; set; }
        public string Name { get; set; } = String.Empty;
        public List<Review> Reviews { get; set; } = new List<Review>();
    }
}