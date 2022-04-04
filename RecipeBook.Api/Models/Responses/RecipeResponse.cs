using RecipeBook.Api.Models.Requests;
using System;
using System.ComponentModel.DataAnnotations;

namespace RecipeBook.Api.Models.Responses
{
    public class RecipeResponse : RecipeRequest
    {
        [Required]
        public string ID { get; set; }

        [Required]
        public byte Score { get; set; }

        [Required]
        public DateTime CreatedAt { set; get; }

        [Required]
        public DateTime LastModified { set; get; }
    }
}
