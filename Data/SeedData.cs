using System;
using System.Collections.Generic;
using System.Linq;
using ClothesRUs.Contexts;
using ClothesRUs.Models;
using ClothesRUs.Models.Enums;
using ClothesRUs.Models.PriceCalculators;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace ClothesRUs.Data
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context =
                new ClothingContext(
                    serviceProvider
                        .GetRequiredService<DbContextOptions<ClothingContext>>()))
            {
                if (!context.Images.Any())
                {
                    SeedImages(context);
                }

                if (!context.Colours.Any())
                {
                    SeedColours(context);
                }

                if (!context.Sizes.Any())
                {
                    SeedSizes(context);
                }
                if (!context.Clothings.Any())
                {
                    SeedClothing(context);
                }
            }
        }
        
        private static void SeedImages(ClothingContext context)
        {
            List<Image> images = new List<Image>();

            for (int i = 0; i < 15; i++)
            {
                Image image = new Image
                {
                    Id = i+10
                };
                images.Add(image);
            }

            context.Images.AddRange(images);

            context.SaveChanges();
        }

        private static void SeedSizes(ClothingContext context)
        {
            context.Sizes.AddRange(new List<Size>
            {
                new Size
                {
                    ActualSize = "Small"
                },
                new Size
                {
                    ActualSize = "Medium"
                },
                new Size
                {
                    ActualSize = "Large"
                }
            });
            
            context.SaveChanges();
        }

        
        private static void SeedColours(ClothingContext context)
        {
            context.Colours.AddRange(new List<Colour>
            {
                new Colour
                {
                    ThisColour = "Red"
                },
                new Colour
                {
                    ThisColour = "Blue"
                },
                new Colour
                {
                    ThisColour = "Green"
                },
                new Colour
                {
                    ThisColour = "White"
                },
                new Colour
                {
                    ThisColour = "Grey"
                },
                new Colour
                {
                    ThisColour = "Black"
                }
            });
            context.SaveChanges();
        }

        private static void SeedClothing(ClothingContext context)
        {
            List<Image> images = context.Images.ToList();
            List<Size> sizes = context.Sizes.ToList();
            List<Colour> colours = context.Colours.ToList();

            context.Clothings.AddRange(
                new Clothing(
                    Sex.Male,
                    Age.Adult,
                    "Boxers",
                    01,
                    "Underbukser",
                    "Sebastians brugte underbukser",
                    123.456,
                    images.GetRange(0, 3),
                    sizes,
                    colours),
                
                new Clothing(
                    Sex.Female,
                    Age.Children,
                    "Shoes",
                    02,
                    "Sko",
                    "Kaares løbesko",
                    0.00,
                    images.GetRange(3, 3),
                    sizes,
                    colours),
                
                new Clothing(
                    Sex.Male,
                    Age.Adult,
                    "T-shirt",
                    03,
                    "Grim t-shirt",
                    "T-shirts som kun Johannes ville gå med. ",
                    10,
                    images.GetRange(6, 3),
                    sizes,
                    colours),
                
                new Clothing(
                    Sex.Male,
                    Age.Adult,
                    "Hat",
                    04,
                    "Slidt hat",
                    "Hat til at gemme bald spots",
                    600,
                    images.GetRange(9, 3),
                    sizes,
                    colours)
            );
            context.SaveChanges();
        }
    }
}