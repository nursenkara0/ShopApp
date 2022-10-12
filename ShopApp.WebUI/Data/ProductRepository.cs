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
            _products = new List<Product> {
                new Product{ ProductId = 1, Name="Iphone 8", Price=3000, Description="İyi telefon", IsApproved=false, ImageUrl = "2.png", CategoryId = 1},
                new Product{ ProductId = 2, Name="Iphone x", Price= 6000, Description= "Çok iyi telefon", IsApproved=true, ImageUrl = "2.png", CategoryId = 1},
                new Product{ ProductId = 3, Name="Iphone 7", Price= 6000, Description= "Çok iyi telefon", IsApproved=true, ImageUrl = "2.png", CategoryId = 1},
                new Product{ ProductId = 4, Name="Iphone 7", Price= 6000, Description= "Çok iyi telefon", ImageUrl = "2.png", CategoryId = 1},
                new Product{ ProductId = 5, Name="Lenova 7", Price= 6000, Description= "Çok iyi bilgisayar", ImageUrl = "2.png", CategoryId = 2},
                new Product{ ProductId = 6, Name="Lenova 8", Price= 6000, Description= "Çok iyi bilgisayar", ImageUrl = "2.png", CategoryId = 2},
                new Product{ ProductId = 7, Name="Lenova 9", Price= 6000, Description= "Çok iyi bilgisayar", ImageUrl = "2.png", CategoryId = 2},
                new Product{ ProductId = 8, Name="Lenova 10", Price= 6000, Description= "Çok iyi bilgisayar", ImageUrl = "2.png", CategoryId = 2},
            };
        }

        public static List<Product> Products
        {
            get
            {
                return _products;
            }
        }
        public static void AddProduct(Product product)
        {
            _products.Add(product);
        }
        public static Product GetProductById(int productId)
        {
            return _products.FirstOrDefault(p => p.ProductId == productId);
        }
    }
}
