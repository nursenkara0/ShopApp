﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApp.WebUI.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        [Required]
        public int? CategoryId { get; set; }
        [Required]
        [StringLength(60,MinimumLength = 10,ErrorMessage = "Ürün ismi için 10-60 karakter arasında olmalıdır")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Fiyat girmelisiniz.")]
        [Range(1,10000)]
        public double? Price { get; set; }
        [Required]
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public bool IsApproved { get; set; }
    }
}
