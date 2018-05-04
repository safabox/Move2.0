using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Move2._0.Dto
{
    public class PaymentDto
    {
       
        public double transaction_amount { get; set; }
        public string token { get; set; }
        public string description { get; set; }
        public int installments { get; set; }
        public string payment_method_id { get; set; }
        public Payer payer { get; set; }
    }
}