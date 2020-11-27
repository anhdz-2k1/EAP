using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DrinkStores01.Models
{
    public class DrinkStroreDBContext : DbContext
    {
        public DrinkStroreDBContext(DbContextOptions<DrinkStroreDBContext> options)
            : base(options) { }

        public DbSet<Product> Products { get; set; }
    }
}
