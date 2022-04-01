using System.ComponentModel.DataAnnotations;

namespace RecipeBook.Api.Models.Requests
{
    public class RecipeRequest
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }
    }
}
