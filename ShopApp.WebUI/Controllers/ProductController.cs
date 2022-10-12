using Microsoft.AspNetCore.Mvc;
using ShopApp.WebUI.Data;
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
        public IActionResult List(int? id, string q)
        {
            var products = ProductRepository.Products;
            if (id!=null)
            {
                products = products.Where(p => p.CategoryId == id).ToList();
            }
            if (!string.IsNullOrEmpty(q))
            {
                products = products.Where(i => i.Name.ToLower().Contains(q.ToLower()) || i.Description.ToLower().Contains(q.ToLower())).ToList();
            }
            var productViewModel = new ProductViewModel()
            {
                Products = products,
            };
            return View(productViewModel);
        }
        public IActionResult Details(int id)
        {

            return View(ProductRepository.GetProductById(id));
        }
    }
}
