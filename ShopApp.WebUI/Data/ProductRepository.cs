using ShopApp.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApp.WebUI.Data
{
    public static class ProductRepository
    {
        private static List<Product> _products = null;
        static ProductRepository()
        {
            _products = new List<Product> { };
        }

        //public static List<Product> Products
        //{

        //}
    }
}
