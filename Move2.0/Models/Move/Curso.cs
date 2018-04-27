using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Move2._0.Models.Move
{
    public class Curso
    {
        [Required]
        public int Id { get; set; }


        [Required]
        [Display(Name="Curso")]
        public string Name { get; set; }

        [Required]
        [Display(Name ="Descripcion")]
        public string Description { get; set; }

        [Required]
        public int MoodleID { get; set; }

        [Required]
        public int NivelId { get; set; }

        public Nivel Nivel { get; set; }

    }
}