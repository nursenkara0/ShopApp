using Microsoft.AspNetCore.Mvc;
using ShopApp.WebUI.Models;
using ShopApp.WebUI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApp.WebUI.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            var product = new Product
            {
                Name = "Iphone 14",
                Price = 35000,
                Description = "İyi telefon"
            };
            ViewData["Product"] = product;
            ViewData["Category"] = "Telefonlar";
            return View();
        }
        public IActionResult List()
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
        public IActionResult Details(int id)
        {
            //ViewBag.Name = "samsung s6";
            //ViewBag.Price = 3000;
            //ViewBag.Description = "İyi telefon";
            var product = new Product();
            product.Name = "Samsung s22";
            product.Price = 22000;
            product.Description = "İyi telefon";
            return View(product);
        }
    }
}
