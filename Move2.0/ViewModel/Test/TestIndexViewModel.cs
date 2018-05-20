using System.ComponentModel.DataAnnotations;

namespace Move2._0.ViewModel.Test
{
    public class TestIndexViewModel
    {
        [Required]
        [Display]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public int NivelTestId { get; set; }

    }
}