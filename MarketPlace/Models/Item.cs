namespace MarketPlace.Models
{
    public class Item
    {
        public int Id { get; set; }
        public int Price { get; set; }
        public string Name { get; set; } = string.Empty;
        public ICollection<Review> Reviews { get; set; } = null!;
        public ICollection<ItemOwner > ItemOwners { get; set; } = null!;
        public ICollection<ItemCategory> ItemCategories { get; set; } = null!;
    }
} 