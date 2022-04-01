using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using RecipeBook.Api.Models.Responses;
using RecipeBook.Business.Definitions;
using System.Collections.Generic;

namespace RecipeBook.Api.Controllers
{
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    [ApiVersion("2.0")]
    [KebabCaseControllerModelConvention]
    public class UltraRecipesController : ControllerBase
    {
        private readonly IRecipesService recipesService;
        private readonly IMapper mapper;

        public UltraRecipesController(IRecipesService recipesService, IMapper mapper)
        {
            this.recipesService = recipesService;
            this.mapper = mapper;
        }

        [HttpGet]
        public IEnumerable<RecipeRespose> GetRecipes()
        {
            return mapper.Map<IEnumerable<RecipeRespose>>(recipesService.GetRecipes());
        }

        [HttpGet]
        [Route("{id}")]
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
