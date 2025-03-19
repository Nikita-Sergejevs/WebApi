namespace MarketPlace.Models
{
    public class Review
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Text { get; set; } = string.Empty;
        public DateTime CreatedOn { get; set; } = DateTime.Now;

        public int? ItemId { get; set; }
        public Item? Item { get; set; }

        public int? OwnerId { get; set; }
        public Owner? Owner { get; set; }
    }
}