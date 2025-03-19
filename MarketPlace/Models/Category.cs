namespace MarketPlace.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public int? ParentCategoryId { get; set; }
        public Category? ParentCatergory { get; set; }

        public ICollection<ItemCategory> ItemCategories { get; set; } = null!;
    }
}