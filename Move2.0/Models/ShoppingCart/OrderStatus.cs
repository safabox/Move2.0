using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Move2._0.Models.ShoppingCart
{
    public class OrderStatus
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [Display(Name ="Estado")]
        public string Status { get; set; }

        [Required]
        [Display(Name ="Descripcion")]
        public string Description { get; set; }


        public const int SUBMIT = 1;
        public const int PENDING = 2;
        public const int APPROVED = 3;
        public const int REJECTED = 4;
        public const int CANCEL = 5;


    }
}