using System.ComponentModel.DataAnnotations;

namespace Apice_ll_Trimestre.Models
{
    public class Disponibilidad
    {
        public int ID { get; set; }

        [Required]
        [Display(Name = "Estudiante")]
        public int ID_Estudiante { get; set; }

        [Required]
        [Display(Name = "Materia")]
        public int ID_Materia { get; set; }

        [Required]
        [Display(Name = "Día de la semana")]
        public string DiaSemana { get; set; }

        [Required]
        [Display(Name = "Hora de inicio")]
        public TimeSpan HoraInicio { get; set; }

        [Required]
        [Display(Name = "Hora final")]
        public TimeSpan HoraFinal { get; set; }
    }
}