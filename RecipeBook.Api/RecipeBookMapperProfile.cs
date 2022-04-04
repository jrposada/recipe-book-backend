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
            CreateMap<Recipe, RecipeResponse>();
            CreateMap<RecipeRequest, Recipe>()
                .ForMember(member => member.ID, options => options.Ignore())
                .ForMember(member => member.Score, options => options.Ignore())
                .ForMember(member => member.CreatedAt, options => options.Ignore())
                .ForMember(member => member.LastModified, options => options.Ignore());
        }
    }
}
