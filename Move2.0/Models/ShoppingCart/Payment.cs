using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Move2._0.Models.ShoppingCart
{
    public class Payment
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public int OrderId { get; set; }

        public Order Order { get; set; }

        [Required]
        public int ClientId { get; set; }

        public Client Client { get; set; }

        [Required]
        public int PaymentStatusId { get; set; }

        public PaymentStatus PaymentStatus { get; set; }



    }
}