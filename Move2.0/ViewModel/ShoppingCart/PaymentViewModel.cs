using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Move2._0.ViewModel.ShoppingCart
{
    public class PaymentViewModel
    {
        [Required]
        [Display]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string  PaymentMethodId { get; set; }

        [Required]
        public string Token { get; set; }

    }
}