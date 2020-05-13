using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StreetPizza.Data.Models
{
    public class Order
    {
        [BindNever]
        public int id { get; set; }

        [Display(Name="Введіть ім*я")]
        [StringLength(25)]
        [Required(ErrorMessage ="Довжина поля не менше 25 символів")]
        public string name { get; set; }

        [Display(Name = "Введіть фамілію")]
        [StringLength(25)]
        [Required(ErrorMessage = "Довжина поля не менше 25 символів")]
        public string surname { get; set; }

        [Display(Name = "Введіть адресу")]
        [StringLength(35)]
        [Required(ErrorMessage = "Довжина поля не менше 35 символів")]
        public string adress { get; set; }

        [Display(Name = "Введіть телефон")]
        [StringLength(20)]
        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Довжина поля не менше 20 символів")]
        public string phone { get; set; }

        [Display(Name = "Введіть email")]
        [StringLength(25)]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Довжина поля не менше 25 символів")]
        public string email { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime orderTime { get; set; }

        public List<OrderDetail> orderDetails { get; set; }

    }
}
