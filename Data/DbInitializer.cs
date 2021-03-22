using System.Linq;
using ClothesRUs.Contexts;
using ClothesRUs.Models;

namespace ClothesRUs.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ClothingContext context)
        {
            context.Database.EnsureCreated();
            
            if (context.Products.Any())
            {
                return;
            }

            var products = new Product[]
            {
                new()
                {
                    Name = "Big Dress",
                    Description = "Big Dress for BIG Women!",
                    Size = "DAMN!",
                    Colors = "BLACK",
                    Price = 999.99,
                    Gender = Gender.Women,
                    Categories = ClothingType.Dresses
                },
                new()
                {
                    Name = "Dat Grass",
                    Description = "It's just grass..",
                    Size = "One Size",
                    Colors = "Green",
                    Price = 156.00,
                    Gender = Gender.Men,
                    Categories = ClothingType.Other
                },
                new()
                {
                    Name = "Swagger Pants",
                    Description = "It's pants just with Swag!",
                    Size = "XXXXXL (American Size)",
                    Colors = "Pink",
                    Price = 99.99,
                    Gender = Gender.Unisex,
                    Categories = ClothingType.Pants
                },
                new()
                {
                    Name = "Womens Panties",
                    Description = "They're very big!",
                    Size = "XXXXXXXL (Big Boned)",
                    Colors = "Barf Green",
                    Price = 5.99,
                    Gender = Gender.Women,
                    Categories = ClothingType.Pants
                },
                new()
                {
                    Name = "Spider Man Cap",
                    Description = "It's Spider Man on a Hat!",
                    Size = "Age 10",
                    Colors = "Spider Man Green",
                    Price = 1.95,
                    Gender = Gender.Children,
                    Categories = ClothingType.Accessories
                }
            };
            
            context.Products.AddRange(products);
            context.SaveChanges();

            var productImages = new ProductImage[]
            {
                new()
                {
                    ProductId = context.Products.Single(p => p.Name == "Big Dress").ProductId,
                    ImageFileLocation = "test/path/image.jpg"
                },
                new()
                {
                    ProductId = context.Products.Single(p => p.Name == "Big Dress").ProductId,
                    ImageFileLocation = "test/path/image.jpg"
                },
                new()
                {
                    ProductId = context.Products.Single(p => p.Name == "Big Dress").ProductId,
                    ImageFileLocation = "test/path/image.jpg"
                }
            };
            
            context.ProductImages.AddRange(productImages);
            context.SaveChanges();
        }
    }
}