namespace RecipeBook.Business.Definitions
{
    using RecipeBook.Repository.Models;
    using System.Collections.Generic;

    public interface IRecipesService
    {
        IEnumerable<Recipe> GetRecipes();
        Recipe GetRecipe(string id);
    }
}
