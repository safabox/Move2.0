using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Move2._0.Models.ShoppingCart;

namespace Move2._0.ViewModel.ShoppingCart
{
    public class ProductInfoViewModel
    {
        public List<Feature> Features { get; set; }
        public Producto Producto { get; set; }
        public bool Recomendado { get; set; }
    }
}