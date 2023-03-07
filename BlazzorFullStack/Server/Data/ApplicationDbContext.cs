using BlazzorFullStack.Shared;
using Microsoft.EntityFrameworkCore;

namespace BlazzorFullStack.Server.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
        
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                   Id = 1,
                   CarType = "Sedan",
                   Url = "sedan",
                },
                new Category
                {
                    Id = 2,
                    CarType = "Sport car",
                    Url = "sportcar"
                },
                new Category
                {
                    Id = 3,
                    CarType = "SUV",
                    Url = "suv"
                }
                );
            modelBuilder.Entity<Car>().HasData(
                new Car { Id = 1, Brand = "Audi", Model = "A8" , Price = 100000m, CategoryId =1 },
            new Car { Id = 2, Brand = "Audi", Model = "RS7", Price = 150000m, CategoryId = 1 },
            new Car { Id = 3, Brand = "BMW", Model = "M7", Price = 200000m, CategoryId = 1},
            new Car { Id = 4, Brand = "BMW", Model = "X7", Price = 210000m, CategoryId = 3 }
            );
        }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
