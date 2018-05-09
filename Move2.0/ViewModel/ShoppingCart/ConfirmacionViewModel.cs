using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Move2._0.ViewModel.ShoppingCart
{
    public class ConfirmacionViewModel
    {
        public int PaymentStatusId { get; set; }
        public string PaymentStatus { get; set; }
        public string PaymentStatusDescription { get; set; }
        public string PaymentMethodId { get; set; }
        public double TransactionAmount { get; set; }
        public int Installments { get; set; }
    }
}