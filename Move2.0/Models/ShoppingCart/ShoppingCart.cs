using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using Move2._0.Models;

namespace Move2._0.Models.ShoppingCart
{
    public class ShoppingCart
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string ApplicationUserId { get; set; }


        public virtual ICollection<Producto> Productos { get; set; }

    }
}