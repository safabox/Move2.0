using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Move2._0.Models.Move
{
    public class Respuesta
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [Display(Name ="")]
        public string Answer { get; set; }

        [Required]
        [Display(Name ="Pregunta")]
        public int PreguntaId { get; set; }

        public Pregunta Question { get; set; }

        public int? NextQuestion { get; set; }

    }
}