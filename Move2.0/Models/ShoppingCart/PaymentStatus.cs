using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Move2._0.Models.ShoppingCart
{
    public class PaymentStatus
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [Display(Name ="Estado de pago")]
        public string Status { get; set; }

        [Required]
        [Display(Name = "Descripcion")]
        public string Description { get; set; }

    }
}