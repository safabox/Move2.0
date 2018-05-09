using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Move2._0.Models.ShoppingCart
{
    public class Client
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public int DNI { get; set; }

        [Required]
        public string ApplicationUserId { get; set; }

        public virtual ICollection<Payment> Payments { get; set; }

        public virtual ICollection<Order> Orders { get; set; }

    }
}