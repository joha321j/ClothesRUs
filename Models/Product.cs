using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ClothesRUs.Models
{
    public abstract class Product
    { public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public List<Image> Images { get; set; }
        
        public abstract List<string> Categories { get;}
        
        protected Product()
        { 
        }
        protected Product(string name, string description, double price, List<Image> images)
        {
            Name = name;
            Description = description;
            Price = price;
            Images = images;
        }
    }
}