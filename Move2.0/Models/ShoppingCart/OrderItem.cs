using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Move2._0.Models.ShoppingCart
{
    public class OrderItem
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [Display(Name ="Precio")]
        public Double Price { get; set; }

        [Required]
        [Display(Name ="Descripcion")]
        public string Description { get; set; }

        [Required]
        [Display(Name ="Cantidad")]
        public int Quantity { get; set; }
    }
}