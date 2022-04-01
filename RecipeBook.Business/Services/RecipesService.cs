namespace RecipeBook.Business.Services
{
    using RecipeBook.Business.Definitions;
    using RecipeBook.Repository.Models;
    using System.Collections.Generic;

    public class RecipesService : IRecipesService
    {
        private readonly Dictionary<string, Recipe> recipes = new()
        {
            {"1", new Recipe() { Id = "1", Name = "Recipe 1", Description = "Perfect recipe for a sunny day!" } },
            {"2", new Recipe() { Id = "2", Name = "Recipe 2", Description = "Perfect recipe for a rainy day!" } },
        };

        public Recipe GetRecipe(string id)
        {
            recipes.TryGetValue(id, out Recipe recipe);

            return recipe;
        }

        public IEnumerable<Recipe> GetRecipes()
        {
            return recipes.Values;
        }
    }
}
