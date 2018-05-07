using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using Move2._0.DAL;
using Move2._0.Models.Move;
using Move2._0.Models.ShoppingCart;
using Move2._0.ViewModel.ShoppingCart;


namespace Move2._0.ViewModel.ShoppingCart
{
    public class CheckOutViewModel
    {
        [Required]
        [Display]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string PaymentMethodId { get; set; }

        [Required]
        public string Token { get; set; }

        public ClientViewModel Client { get; set; }
    }
}