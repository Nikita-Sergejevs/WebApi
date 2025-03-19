using MarketPlace.Models;
using Microsoft.Identity.Client;

namespace MarketPlace.Data
{
    public static class Seed
    {
        public static void Initialize(DataContext context)
        {
            if(context.Item.Any() || context.Categories.Any()) return;

            var categories = new List<Category>
            {
                new Category { Id = 0, Name = "Armor" },
                new Category { Id = 1, Name = "Blocks" },
                new Category { Id = 2, Name = "Food" },
                new Category { Id = 3, Name = "Tools" },
                new Category { Id = 4, Name = "Weapon" }
            };

            var item = new List<Item>
            {
                new Item { Id = 0, Name = "" }
            };

            var owner = new List<Owner>
            {

            };

            var reviews = new List<Review>
            {

            };
        }
    }
}