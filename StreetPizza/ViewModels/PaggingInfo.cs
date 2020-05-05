using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StreetPizza.ViewModels
{
    public class PaggingInfo
    {
        //всього товарів в базі
        public int TotalItems { get; set; }
        //всього товарів на сторінці
        public int ItemsPerPage { get; set; }
        //номер поточної сторінки
        public int CurrentPage { get; set; }
        //загальна кількість сторінок
        public int TotalPages => 
            (int)Math.Ceiling((decimal)TotalItems / ItemsPerPage);
    }
}
