using System.ComponentModel.DataAnnotations;

namespace Apice_ll_Trimestre.Models
{
    public class Evaluacion
    {
        public int ID { get; set; }

        [Required]
        [Display(Name = "Materia")]
        public int ID_Materia { get; set; }

        [Required]
        [Display(Name = "Estudiante")]
        public int ID_Estudiante { get; set; }

        [Required]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }

        [Required]
        [Range(0, 100, ErrorMessage = "El porcentaje debe estar entre 0 y 100.")]
        [Display(Name = "Porcentaje")]
        public decimal Porcentaje { get; set; }

        [Range(0, 100, ErrorMessage = "La nota debe estar entre 0 y 100.")]
        [Display(Name = "Nota")]
        public decimal? Nota { get; set; }
    }
}