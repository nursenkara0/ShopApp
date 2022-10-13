using Microsoft.AspNetCore.Mvc;
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
            //if (RouteData.Values["action"].ToString() == "List")
            //{
            //    ViewBag.SelectedCategory = RouteData?.Values["id"];
            //}
            //return View(CategoryRepository.Categories);
            return View();
        }
    }
}
