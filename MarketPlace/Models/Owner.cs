namespace MarketPlace.Models
{
    public class Owner
    {
        public int Id { get; set; }
        public double Distance { get; set; }
        public string Name { get; set; } = string.Empty;
        public ICollection<ItemOwner> ItemOwners { get; set; } = null!;
    }
}