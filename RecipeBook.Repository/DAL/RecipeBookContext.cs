using Microsoft.EntityFrameworkCore;
using RecipeBook.Repository.Models;

namespace RecipeBook.Repository.DAL
{
    public class RecipeBookContext : DbContext
    {
        public DbSet<Recipe> Recipes { get; set; }

        public RecipeBookContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Recipe>().HasData(
                new Recipe() { ID = "1", Name = "Recipe 1", Description = "Perfect recipe for a sunny day!" },
                new Recipe() { ID = "2", Name = "Recipe 2", Description = "Perfect recipe for a rainy day!" });
        }
    }
}
