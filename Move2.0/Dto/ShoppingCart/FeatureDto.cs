﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Move2._0.Dto.ShoppingCart
{
    public class FeatureDto
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Característica")]
        public string Name { get; set; }

        public string Tooltip { get; set; }

        public virtual ICollection<ProductoDto> Productos { get; set; }
    }
}