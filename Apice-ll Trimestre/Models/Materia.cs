using System.ComponentModel.DataAnnotations;

namespace Apice_ll_Trimestre.Models
{
    public class Materia
    {
        public int ID { get; set; }

        [Required]
        [Display(Name = "Estudiante")]
        public int ID_Estudiante { get; set; }

        [Required]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }

        [Required]
        [Display(Name = "Prioridad")]
        public string Prioridad { get; set; }

        [Display(Name = "Estado")]
        public bool Estado { get; set; }

        [Range(0, 100, ErrorMessage = "La nota mínima debe estar entre 0 y 100.")]
        [Display(Name = "Nota mínima")]
        public decimal? NotaMinima { get; set; }

        [Required]
        [Display(Name = "Color")]
        public string Color { get; set; } // ej: "#FF5733"
    }
}