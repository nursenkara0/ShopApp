using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ShopApp.Entity;
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
            //var products = ProductRepository.Products;
            //if (id!=null)
            //{
            //    products = products.Where(p => p.CategoryId == id).ToList();
            //}
            //if (!string.IsNullOrEmpty(q))
            //{
            //    products = products.Where(i => i.Name.ToLower().Contains(q.ToLower()) || i.Description.ToLower().Contains(q.ToLower())).ToList();
            //}
            //var productViewModel = new ProductViewModel()
            //{
            //    Products = products,
            //};
            //return View(productViewModel);
            return View();
        }
        public IActionResult Details(int id)
        {

            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            //ViewBag.Categories = new SelectList(CategoryRepository.Categories,"CategoryId","Name");
            return View(new Product());
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            //if (ModelState.IsValid)
            //{
            //    ProductRepository.AddProduct(product);
            //    return RedirectToAction("list");
            //}
            //ViewBag.Categories = new SelectList(CategoryRepository.Categories, "CategoryId", "Name");
            return View();
           
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            //ViewBag.Categories = new SelectList(CategoryRepository.Categories, "CategoryId", "Name");
            return View();
        }
        [HttpPost]
        public IActionResult Edit(Product product)
        {
            //ProductRepository.EditProduct(product);
            return RedirectToAction("list");
        }
        [HttpPost]
        public IActionResult Delete(int ProductId)
        {
            //ProductRepository.DeleteProduct(ProductId);
            return RedirectToAction("list");
        }

    }
}
