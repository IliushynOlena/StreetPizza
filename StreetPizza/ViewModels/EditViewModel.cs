using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StreetPizza.ViewModels
{
    public class EditViewModel : CreateProductsViewModel
    {
        public int Id { get; set; }
        public string ExistImgPath { get; set; }

    }
}
