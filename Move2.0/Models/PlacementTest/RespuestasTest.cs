using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Move2._0.Models.PlacementTest
{
    public class RespuestasTest
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Respuesta")]
        public string Respuesta { get; set; }

        [Required]
        public Boolean Correcta { get; set; }

        [Required]
        public int PregunstasTestId { get; set; }
        public PreguntasTest PreguntasTest { get; set; }

    }
}