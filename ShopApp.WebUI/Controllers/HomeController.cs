using Microsoft.AspNetCore.Mvc;
using ShopApp.WebUI.Models;
using ShopApp.WebUI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApp.WebUI.Controllers
{
    public class HomeController:Controller
    {
        public IActionResult Index()
        {
            var products = new List<Product>()
            {
                new Product{Name="Iphone 8",Price=3000,Description="İyi telefon",IsApproved=true},
                new Product{Name="Iphone x", Price= 6000, Description= "Çok iyi telefon"}
            };
            var productViewModel = new ProductViewModel()
            {
                Products = products,
            };
            return View(productViewModel);
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View("MyView");
        }
    }
}
