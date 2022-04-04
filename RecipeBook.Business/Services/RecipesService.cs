using RecipeBook.Business.Definitions;
using RecipeBook.Repository.DAL;
using RecipeBook.Repository.Models;
using System.Collections.Generic;

namespace RecipeBook.Business.Services
{
    public class RecipesService : IRecipesService
    {
        private readonly RecipeBookContext context;

        public RecipesService(RecipeBookContext context)
        {
            this.context = context;
        }

         public Recipe GetRecipe(string id)
        {
            var recipe = context.Set<Recipe>().Find(id);

            return recipe;
        }

        public IEnumerable<Recipe> GetRecipes()
        {
            return context.Set<Recipe>();
        }
    }
}
