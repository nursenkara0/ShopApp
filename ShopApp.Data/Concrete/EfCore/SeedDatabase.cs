using Microsoft.EntityFrameworkCore;
using ShopApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShopApp.Data.Concrete.EfCore
{
    public static class SeedDatabase
    {
        public static void Seed()
        {
            var context = new ShopContext();
            if (context.Database.GetPendingMigrations().Count() == 0)
            {
                if (context.Categories.Count() == 0)
                {
                    context.Categories.AddRange(Categories);
                }

                if (context.Products.Count() == 0)
                {
                    context.Products.AddRange(Products);
                }
            }
            context.SaveChanges();
        }
        private static Category[] Categories =
        {
            new Category(){Name = "Telefon" },
            new Category(){Name = "Bilgisayar" },
            new Category(){Name = "Elektronik" }
        };

        private static Product[] Products =
      {
            new Product(){Name = "Samsung S5", Price = 2000, ImageUrl = "1.png",Description="iyi telefon",IsApproved = true },
            new Product(){Name = "Samsung S6", Price = 2000, ImageUrl = "1.png",Description="iyi telefon",IsApproved = false },
            new Product(){Name = "Samsung S7", Price = 2000, ImageUrl = "1.png",Description="iyi telefon",IsApproved = true },
            new Product(){Name = "Samsung S8", Price = 2000, ImageUrl = "1.png",Description="iyi telefon",IsApproved = false },
            new Product(){Name = "Samsung S9", Price = 2000, ImageUrl = "1.png",Description="iyi telefon",IsApproved = true }
        };
    }
}
