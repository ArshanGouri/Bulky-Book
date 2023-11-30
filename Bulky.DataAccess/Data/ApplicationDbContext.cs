using Bulky.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Bulky.DataAccess.Data
{
    public class ApplicationDbContext:IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options) 
        {
                
        }
        //Name of Table : Categories, Category is the Model name
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);//requires for IdentityDbContext
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    Name = "Action",
                    DisplayOrder = 1
                },
                  new Category
                  {
                      Id = 2,
                      Name = "SciFi",
                      DisplayOrder = 2
                  },
                    new Category
                    {
                        Id = 3,
                        Name = "History",
                        DisplayOrder = 3
                    }
                    );
            modelBuilder.Entity<Product>().HasData(
           new Product
           {
               Id = 1,
               Title = "Serenade of the Sire",
               Author= "Dominic Steele",
               Description= "Immerse yourself in a tale of forbidden love and mythical creatures beneath the moonlit waves. \"Serenade of the Sirens\" follows the journey of Tristan, a young sailor who discovers a world of enchantment beneath the surface.",
               ISBN= "978-3-456789-01-2",
               ListPrice=19,
               Price=90,
               Price50=15,
               Price100=10,
               CategoryId=1,
               ImageUrl=""
           },
           new Product
           {
               Id = 2,
               Title = "Echoes in the Shadows",
               Author = "Seraphina Nightshade",
               Description = "Description2",
               ISBN = "978-1-234237-11-1",
               ListPrice = 89,
               Price = 10,
               Price50 = 65,
               Price100 = 69,
               CategoryId = 2,
               ImageUrl=""

           },
           new Product
           {
               Id = 3,
               Title = "Whispers of Eternity",
               Author = "Seraphina Nightshade",
               Description = "Description3",
               ISBN = "978-1-234567-89-0",
               ListPrice = 89,
               Price = 10,
               Price50 = 65,
               Price100 = 60,
               CategoryId = 1,
               ImageUrl=""

           },
           new Product
           {
               Id = 4,
               Title = "Chronicles of the Celestial Oracle",
               Author = "Orion Starweaver",
               Description = "Embark on an epic quest across celestial realms as destiny unfolds in the hands of the chosen one. \"Chronicles of the Celestial Oracle\" weaves a tapestry of magic, prophecy, and friendship as protagonist Elara discovers her role in preserving the cosmic balance.",
               ISBN = "978-4-567890-12-3",
               ListPrice = 89,
               Price = 10,
               Price50 = 65,
               Price100 = 60,
               CategoryId = 3,
               ImageUrl=""// Update the CategoryId to match a valid category (e.g., 1)
           }
            );
        }
    }
}
