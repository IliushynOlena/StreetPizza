using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StreetPizza.ViewModels
{
    public class CreateProductsViewModel
    {
        [Required]
        [MaxLength(30, ErrorMessage = "Name can't exceed 30 characters")]
        public string Name { get; set; }
       
        public IFormFile Img { get; set; }

        [Required]
        [MaxLength(200, ErrorMessage = "Name can't exceed 200 characters")]
        public string Ingredients { get; set; }

        public ushort PriceMedium { get; set; }
        [Required]
        public string PriceLarge { get; set; }
        public bool IsFavorite { get; set; }
        [Required]
        public string Category { get; set; }
    }
}
