using System;
using System.Collections.Generic;
using ClothesRUs.Models.Enums;
using ClothesRUs.Models.PriceCalculators;

namespace ClothesRUs.Models
{
    public class Clothing: Product
    {
        public int Id { get; set; }
        private readonly Sex _sex;
        private readonly Age _age;
        private readonly string _type;

        private List<Size> Sizes { get; }
        private List<Colour> Colours { get; }

        public Clothing()
        {
        }

        public Clothing(
            Sex sex, 
            Age age, 
            string type, 
            int productId, 
            string name, 
            string description, 
            double price, 
            List<Image> images,
            List<Size> sizes,
            List<Colour> colours) 
            : 
            base(
                productId,  
                name, 
                description, 
                price, 
                images)
        {
            _sex = sex;
            _age = age;
            _type = type;
            Sizes = sizes;
            Colours = colours;
        }

        public override List<string> Categories
        {
            get
            {
                List<string> categories = new List<string> {
                    _sex.ToString(),
                    _age.ToString(),
                    _type
                };
                return categories;
            }
        }
    }
}