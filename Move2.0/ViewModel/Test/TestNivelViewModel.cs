using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using Move2._0.Dto.Test;

namespace Move2._0.ViewModel.Test
{
    public class TestNivelViewModel
    {
       
        [Required]
        public string Email { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public List<PreguntasTestDto> PreguntasTestDto { get; set; }

        [Required]
        public List<RespuestasTestDto> RespuestasTestDto { get; set; }

        public List<string> RespustaSeleccionada { get; set; } 

        [Required]
        public int NivelTestId { get; set; }

    }
}