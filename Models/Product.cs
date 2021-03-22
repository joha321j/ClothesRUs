using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ClothesRUs.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Size { get; set; }
        public string Colors { get; set; }
        public double Price { get; set; }
        public Gender Gender { get; set; }
        public ClothingType Categories { get; set; }
        
        public ICollection<ProductImage> Images { get; set; }

    }
    
    public class ProductImage
    {
        [Key]
        public int ProductImageId { get; set; }
        public int ProductId { get; set; }
        public string ImageFileLocation { get; set; }

        public Product Product { get; set; }
    }
    
    public enum ClothingType
    {
        Dresses,
        Shirts,
        Pants,
        Accessories,
        Other
    }
    
    public enum Gender
    {
        Men,
        Women,
        Children,
        Unisex
    }
}