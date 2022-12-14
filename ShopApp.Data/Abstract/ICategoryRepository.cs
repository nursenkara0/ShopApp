using ShopApp.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopApp.Data.Abstract
{
    public interface ICategoryRepository:IRepository<Category>
    {
        List<Category> GetPopularCategories();
    }
}
