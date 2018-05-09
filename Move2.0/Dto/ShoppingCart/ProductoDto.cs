using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace Move2._0.Dto.ShoppingCart
{
    public class ProductoDto
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Producto")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Descripcion")]
        public string Description { get; set; }

        [Required]
        [Display(Name = "Precio")]
        public double Price { get; set; }


        [Required]
        public DateTime StartingDate { get; set; }


        [Required]
        public DateTime? EndDate { get; set; }


        [Display(Name = "Summary")]
        public string Summary { get; set; }

        public virtual ICollection<FeatureDto> Features { get; set; }

    }
}