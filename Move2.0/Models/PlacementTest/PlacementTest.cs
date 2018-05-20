using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Move2._0.Models.PlacementTest
{
    public class PlacementTest
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }

        [Required]
        [Display(Name = "Mail")]
        public string Mail { get; set; }

        [Required]
        [Display(Name = "Nivel")]
        public int Nivel { get; set; }

     }
}