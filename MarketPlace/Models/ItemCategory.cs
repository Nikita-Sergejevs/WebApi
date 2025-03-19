 namespace MarketPlace.Models
 {
    public class ItemCategory
    {
        public int ItemId { get; set; }
        public int CategoryId { get; set; } 
        public Item Item { get; set; } = null!;
        public Category Category  { get; set; } = null!;
    }
 }