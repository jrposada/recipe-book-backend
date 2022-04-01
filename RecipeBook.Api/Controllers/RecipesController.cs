using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using RecipeBook.Api.Models.Responses;
using RecipeBook.Business.Definitions;
using System.Collections.Generic;

namespace RecipeBook.Api.Controllers
{
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    [ApiVersion("1.0")]
    [ApiVersion("2.0")]
    [KebabCaseControllerModelConvention]
    public class RecipesController : ControllerBase
    {
        private readonly IRecipesService recipesService;
        private readonly IMapper mapper;

        public RecipesController(IRecipesService recipesService, IMapper mapper)
        {
            this.recipesService = recipesService;
            this.mapper = mapper;
        }

        [HttpGet]
        [MapToApiVersion("1.0")]
        [MapToApiVersion("2.0")]
        public IEnumerable<RecipeRespose> GetRecipes()
        {
            return mapper.Map<IEnumerable<RecipeRespose>>(recipesService.GetRecipes());
        }

        [HttpGet]
        [Route("{id}")]
        [MapToApiVersion("2.0")]
        [Produces(typeof(ActionResult<RecipeRespose>))]
        public ActionResult<RecipeRespose> GetRecipe(string id)
        {
            var recipe = recipesService.GetRecipe(id);

            if (recipe == null)
            {
                return NotFound();
            }

            return mapper.Map<RecipeRespose>(recipe);
        }


    }
}
