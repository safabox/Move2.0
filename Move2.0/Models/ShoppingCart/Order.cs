using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Move2._0.Models.ShoppingCart
{
    public class Order
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string ApplicationUserId { get; set; }

        [Required]
        [Display(Name ="Fecha de creacion")]
        public DateTime CreatedDate { get; set; }

        
        [Display(Name = "Fecha de aprobacion")]
        public Nullable<DateTime> approvalDate { get; set; }

        [Required]
        public int OrderStatusId { get; set; }
        public OrderStatus Status { get; set; }

        

        [Required]
        public int PaymentId { get; set; }
        public Payment Payment { get; set; }

        [Required]
        public int ClientId { get; set; }
        public Client Client { get; set; }

        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}