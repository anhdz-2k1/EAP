using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using HummanResourcesManagement.Models;

namespace HummanResourcesManagement.Controllers
{
    public class HomeController : Controller
    {
        private IfRepository repository;
        public IActionResult Index() => View(repository.Employees);
        public HomeController(IfRepository repo)
        {
            repository = repo;
        }
    }
}
