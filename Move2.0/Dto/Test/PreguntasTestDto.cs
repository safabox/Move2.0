using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using Move2._0.Models.PlacementTest;

namespace Move2._0.Dto.Test
{
    public class PreguntasTestDto
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Pregunta { get; set; }

        public int IdRespuesta { get; set; }   

        public int NivelTestId { get; set; }

    }
}