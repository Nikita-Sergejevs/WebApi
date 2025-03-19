using MarketPlace.Models;
using Microsoft.Identity.Client;

namespace MarketPlace.Data
{
    public static class Seed
    {
        public static void Initialize(DataContext context)
        {
            if(context.Item.Any() || context.Categories.Any() || context.Owners.Any()) return;

            Random random = new Random();

            int randomWorldRange = random.Next(1, 49);
            int randomNetherRange = random.Next(50, 200);

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
                new Item { Id = 0, Name = "" , Price = 1}
            };

            var owner = new List<Owner>
            {
                //WorldRange distance
                new Owner { Id = 0, Distance = randomWorldRange, Name = "Steve" },
                new Owner { Id = 1, Distance = randomWorldRange, Name = "Alex" },
                new Owner { Id = 2, Distance = randomWorldRange, Name = "Iron Golem" },
                new Owner { Id = 3, Distance = randomWorldRange, Name = "Villager" },
                new Owner { Id = 4, Distance = randomWorldRange, Name = "Pillager" },

                //NetherRange distance
                new Owner { Id = 5, Distance = randomNetherRange, Name = "Witch" },
                new Owner { Id = 6, Distance = randomNetherRange, Name = "Piglin" },
                new Owner { Id = 7, Distance = randomNetherRange, Name = "Enderman" },
                new Owner { Id = 8, Distance = randomNetherRange, Name = "Zombie" }
            };

            var reviews = new List<Review>
            {

            };
        }
    }
}