using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Move2._0.Models.PlacementTest
{
    public class PreguntasTest
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Pregunta")]
        public string Pregunta { get; set; }

        [Required]
        [Display(Name = "CantidadOk")]
        public int CantidadOk { get; set; }

        [Required]
        [Display(Name = "CantidadNoOk")]
        public int CantidadNoOk { get; set; }

        public int NivelTestId { get; set; }
        public NivelTest NivelTest { get; set; }

        public IEnumerable<RespuestasTest> RespuestasTests { get; set; }
    }
}