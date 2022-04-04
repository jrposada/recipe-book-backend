using RecipeBook.Repository.Models;
using System.Collections.Generic;

namespace RecipeBook.Repository.DAL
{
    class RecipeBookInitializer
    {
        protected static void Initialize(RecipeBookContext context)
        {
            var recipes = new List<Recipe>
            {
                new Recipe() { Name = "Recipe 1", Description = "Perfect recipe for a sunny day!" },
                new Recipe() { Name = "Recipe 2", Description = "Perfect recipe for a rainy day!" },
            };

            recipes.ForEach(r => context.Recipes.Add(r));
            context.SaveChanges();
        }
    }
}
