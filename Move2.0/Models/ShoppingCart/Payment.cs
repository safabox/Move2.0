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
        public int PaymentStatusId { get; set; }

        public PaymentStatus PaymentStatus { get; set; }

        [Required]
        [Display(Name ="Fecha de Creacion")]
        public DateTime DateCreated { get; set; }

        
        [Display(Name = "Fecha de Aprobacion")]
        public Nullable<DateTime> ApprovalDate { get; set; }

        
        [Display(Name = "Ultima Actualizacion")]
        public Nullable<DateTime> LastUpdatedTime { get; set; }


        public Nullable<int> MercadoPagoId { get; set; }

    }
}