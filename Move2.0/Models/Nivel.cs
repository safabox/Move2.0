using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Move2._0.Models
{
    public class Nivel
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [Display(Name ="Nivel")]
        public string Name { get; set; }

        [Required]
        [Display(Name="Descripcion")]
        public string Description { get; set; }


        public IEnumerable<Curso> Cursos { get; set; }

    }
}