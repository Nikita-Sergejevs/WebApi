namespace MarketPlace.Models
{
    public class Owner
    {
        public int Id { get; set; } 
        public double Distance { get; set; }
        public double Raiting { get; set; }
        public string Name { get; set; } = string.Empty;
        public List<Review> Reviews { get; set; } = new List<Review>();
    }
}