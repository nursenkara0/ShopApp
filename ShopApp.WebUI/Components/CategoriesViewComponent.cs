using Microsoft.AspNetCore.Mvc;
using ShopApp.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApp.WebUI.Components
{
    public class CategoriesViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var categories = new List<Category>()
            {
                new Category { Name = "Telefon", Description = "Telefon Kategorisi" },
                new Category { Name = "Bilgisayar", Description = "Bilgisayar Kategorisi" },
                new Category { Name = "Elektronik", Description = "Elektronik Kategorisi" },
            };
            return View(categories);
        }
    }
}
