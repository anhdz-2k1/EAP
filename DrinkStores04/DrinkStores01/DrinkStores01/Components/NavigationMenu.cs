using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DrinkStores01.Models;

namespace DrinkStores01.Components
{
    public class NavigationMenu : ViewComponent
    {
        private IStoreRepository repository;

        public NavigationMenu(IStoreRepository repo)
        {
            repository = repo;
        }

        public IViewComponentResult Invoke()
        {
            return View(repository.Products
                .Select(x => x.Category)
                .Distinct()
                .OrderBy(x => x));
        }
        //public string Invoke()
        //{
        //    return "Xin chào các bạn đã đến với cửa hàng của chúng tôi, Tại đây các bạn có thể thỏa sức tham khảo và mua bất cứ thứ đồ uống gì mà bạn thích chỉ cần bạn là người có tiền";
        //}
    }
}
