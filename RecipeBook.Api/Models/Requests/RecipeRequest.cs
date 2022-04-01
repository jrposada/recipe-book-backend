namespace RecipeBook.Api.Models.Requests
{
    using System;

    public class RecipeRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public byte Score { get; set; }
        public DateTime CreatedAt { set; get; }
        public DateTime LastModified { set; get; }
    }
}
