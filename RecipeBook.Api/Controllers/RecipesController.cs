using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RecipeBook.Api.Models.Responses;
using RecipeBook.Business.Definitions;
using System.Collections.Generic;

namespace RecipeBook.Api.Controllers
{
    /// <summary>
    /// Recipes controller.
    /// </summary>
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    [ApiVersion("1.0")]
    [KebabCaseControllerModelConvention]
    [Produces("application/json")]

    public class RecipesController : ControllerBase
    {
        private readonly IRecipesService recipesService;
        private readonly IMapper mapper;

        /// <summary>
        /// Creates a new instance of the controller.
        /// </summary>
        /// <param name="recipesService">Recipes service.</param>
        /// <param name="mapper">Automapper.</param>
        public RecipesController(IRecipesService recipesService, IMapper mapper)
        {
            this.recipesService = recipesService;
            this.mapper = mapper;
        }

        /// <summary>
        /// Gets all the recipes.
        /// </summary>
        /// <returns></returns>
        /// <response code="200">Returns the list of recipes.</response>
        [HttpGet]
        [MapToApiVersion("1.0")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<IEnumerable<RecipeResponse>> GetRecipes()
        {
            return Ok(mapper.Map<IEnumerable<RecipeResponse>>(recipesService.GetRecipes()));
        }

        /// <summary>
        /// Gets an specific recipe.
        /// </summary>
        /// <param name="id">Recipe id.</param>
        /// <returns></returns>
        /// <response code="200">Returns the recipe with the provided id.</response>
        /// <response code="404">If there is no recipe with provided id.</response>
        [HttpGet]
        [MapToApiVersion("1.0")]
        [Route("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<RecipeResponse> GetRecipe(string id)
        {
            var recipe = recipesService.GetRecipe(id);

            if (recipe == null)
            {
                return NotFound();
            }

            return Ok(mapper.Map<RecipeResponse>(recipe));
        }


    }
}
