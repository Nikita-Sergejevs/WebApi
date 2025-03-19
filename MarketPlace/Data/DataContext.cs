using MarketPlace.Models;
using Microsoft.EntityFrameworkCore;

namespace MarketPlace.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Item> Item { get; set; }
        public DbSet<ItemCategory> ItemCategories { get; set; }
        public DbSet<ItemOwner> ItemOwners { get; set; }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Reviewer> Reviewers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ItemCategory>()
                .HasKey(ic => new { ic.ItemId, ic.CategoryId });
            modelBuilder.Entity<ItemCategory>()
                .HasOne(i => i.Item)
                .WithMany(ic => ic.ItemCategories)
                .HasForeignKey(c => c.ItemId);
            modelBuilder.Entity<ItemCategory>()
                .HasOne(i => i.Category)
                .WithMany(ic => ic.ItemCategories)
                .HasForeignKey(c => c.CategoryId);
            
            modelBuilder.Entity<ItemOwner>()
                .HasKey(io => new { io.ItemId, io.OwnerId });
            modelBuilder.Entity<ItemOwner>()
                .HasOne(i => i.Item)
                .WithMany(io => io.ItemOwners)
                .HasForeignKey(o => o.ItemId);
            modelBuilder.Entity<ItemOwner>()
                .HasOne(i => i.Owner)
                .WithMany(io => io.ItemOwners)
                .HasForeignKey(o => o.OwnerId);
        }
    }
}