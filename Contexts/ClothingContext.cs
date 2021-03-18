using System.IO;
using ClothesRUs.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace ClothesRUs.Contexts
{
    public class ClothingContext : DbContext
    {
        public ClothingContext(DbContextOptions<ClothingContext> options) : base(options)
        {
        }

        public DbSet<Clothing> Clothings { get; set; }
        public DbSet<Image> Images { get; set; }
    }
}