using ClothesRUs.Models;
using Microsoft.EntityFrameworkCore;

namespace ClothesRUs.Contexts
{
    public class ClothingContext : DbContext
    {
        public ClothingContext(DbContextOptions<ClothingContext> options) : base(options)
        {
        }

        public DbSet<Clothing> Clothings { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<Colour> Colours { get; set; }
    }
}