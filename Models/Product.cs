using System;
using System.Collections.Generic;

namespace ClothesRUs.Models
{
    public abstract class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public List<Image> Images { get; set; }
        
        public abstract List<string> Categories { get;}
        
        protected Product()
        { 
        }
        protected Product(int productId, string name, string description, double price, List<Image> images)
        {
            ProductId = productId;
            Name = name;
            Description = description;
            Price = price;
            Images = images;
        }
    }
}