using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Move2._0.Models
{
    public class Pregunta
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [Display(Name ="")]
        public string Question { get; set; }
    }
}