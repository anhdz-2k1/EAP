using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrinkStores01.Models
{
    public class EFStoreRepository : IStoreRepository
    {
        private DrinkStroreDBContext context;
        public EFStoreRepository(DrinkStroreDBContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Product> Products => context.Products;
    }
}
