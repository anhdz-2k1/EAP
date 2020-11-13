using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace DrinkStores01.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            DrinkStroreDBContext context = app.ApplicationServices
                .CreateScope().ServiceProvider.GetRequiredService<DrinkStroreDBContext>();
            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }    
            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product
                    {
                        Name = "Cocacola",
                        Description = "Et in lobortis consetetur accusam ut ea diam ipsum consequat amet amet",
                        Img = "..........",
                        Price = 23000,
                        Discount = 0,
                        Status = "Done"                       
                    },
                    new Product
                    {
                        Name = "Pepsi",
                        Description = "Et in lobortis consetetur accusam ut ea diam ipsum consequat amet amet",
                        Img = "..........",
                        Price = 20000,
                        Discount = 0,
                        Status = "Done"
                    },
                    new Product
                    {
                        Name = "Pepsi chanh khong calo",
                        Description = "Et in lobortis consetetur accusam ut ea diam ipsum consequat amet amet",
                        Img = "..........",
                        Price = 25000,
                        Discount = 0,
                        Status = "Done"
                    },
                    new Product
                    {
                        Name = "Sting",
                        Description = "Et in lobortis consetetur accusam ut ea diam ipsum consequat amet amet",
                        Img = "..........",
                        Price = 16000,
                        Discount = 0,
                        Status = "Done"
                    },
                    new Product
                    {
                        Name = "Sting do",
                        Description = "Et in lobortis consetetur accusam ut ea diam ipsum consequat amet amet",
                        Img = "..........",
                        Price = 16000,
                        Discount = 0,
                        Status = "Done"
                    },
                    new Product
                    {
                        Name = "Sting vang",
                        Description = "Et in lobortis consetetur accusam ut ea diam ipsum consequat amet amet",
                        Img = "..........",
                        Price = 16000,
                        Discount = 0,
                        Status = "Done"
                    },
                    new Product
                    {
                        Name = "Tra thai",
                        Description = "Et in lobortis consetetur accusam ut ea diam ipsum consequat amet amet",
                        Img = "..........",
                        Price = 20000,
                        Discount = 0,
                        Status = "Done"
                    }
                    );
                context.SaveChanges();
            }    
        }
    }
}
