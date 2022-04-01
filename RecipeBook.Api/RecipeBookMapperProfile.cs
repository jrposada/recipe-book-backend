using AutoMapper;
using RecipeBook.Api.Models.Requests;
using RecipeBook.Api.Models.Responses;
using RecipeBook.Repository.Models;
using System;

namespace RecipeBook.Api
{
    public class RecipeBookMapperProfile : Profile
    {
        public RecipeBookMapperProfile()
        {
            // Recipe
            CreateMap<Recipe, RecipeRespose>();
            CreateMap<RecipeRequest, Recipe>().ForMember(member => member.Id, options => options.Ignore());
        }
    }
}
