namespace DotNetProductAPI.Models
{
    public class Product
    {
        public int Id { get; set; } // Primary key
        public string? Name { get; set; } // Name of the product 
        public decimal? Price { get; set; } // Price of the product 
        public string? Description { get; set; } // Optional description 
    }
}