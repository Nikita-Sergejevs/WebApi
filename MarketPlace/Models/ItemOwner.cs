namespace MarketPlace.Models
{
    public class ItemOwner
    {
        public int ItemId { get; set; }
        public int OwnerId { get; set; }       
        public Item Item { get; set; } = new();
        public Owner Owner { get; set; } = new();
    }
}