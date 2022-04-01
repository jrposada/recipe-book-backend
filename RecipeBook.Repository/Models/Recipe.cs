namespace RecipeBook.Repository.Models
{
    using System;

    public class Recipe
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public byte Score { get; set; }
        public DateTime CreatedAt { set; get; }
        public DateTime LastModified { set; get; }

    }
}
