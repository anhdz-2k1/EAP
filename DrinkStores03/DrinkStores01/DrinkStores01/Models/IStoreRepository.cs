using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrinkStores01.Models
{
    public interface IStoreRepository
    {
        IQueryable<Product> Products { get; }
    }
}
