using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using Move2._0.Dto.Test;

namespace Move2._0.ViewModel.Test
{
    public class TestFinViewModel
    {
        [Required]
        public string Email { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public int NivelTestId { get; set; }

        [Required]
        public string DescripcionNivel { get; set; }
    }
}