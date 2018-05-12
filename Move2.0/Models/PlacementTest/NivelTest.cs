using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Move2._0.Models.PlacementTest
{
    public class NivelTest
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }

        [Required]
        [Display(Name = "Numero")]
        public int Numero { get; set; }

        [Required]
        [Display(Name = "CantidadRespuesIncorrectas")]
        public int CantidadRespuestasIncorrectas { get; set; }

        public IEnumerable<PreguntasTest> PreguntasTests { get; set; }

    }
}