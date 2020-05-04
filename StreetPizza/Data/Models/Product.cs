using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StreetPizza.Data.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(30, ErrorMessage = "Name can't exceed 30 characters")]
        public string Name { get; set; }
        public string Img { get; set; }

        [Required]
        [MaxLength(200, ErrorMessage = "Name can't exceed 200 characters")]
        public string Ingredients { get; set; }

        [Required]
        public ushort PriceMedium { get; set; }
        public ushort PriceLarge { get; set; }
        public bool IsFavorite { get; set; }
    }
}
