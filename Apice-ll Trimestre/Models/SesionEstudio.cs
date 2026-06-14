using System.ComponentModel.DataAnnotations;

namespace Apice_ll_Trimestre.Models
{
    public class SesionEstudio
    {
        public int ID { get; set; }

        [Required]
        [Display(Name = "Estudiante")]
        public int ID_Estudiante { get; set; }

        [Required]
        [Display(Name = "Materia")]
        public int ID_Materia { get; set; }

        [Required]
        [Display(Name = "Fecha")]
        public DateTime Fecha { get; set; }

        [Required]
        [Display(Name = "Duración total (minutos)")]
        public int Duracion { get; set; }

        [Display(Name = "Tiempo transcurrido (minutos)")]
        public int TiempoTranscurrido { get; set; } = 0;

        [Required]
        [Display(Name = "Cantidad de bloques")]
        public int CantidadBloques { get; set; }

        [Display(Name = "Completada")]
        public bool Completada { get; set; } = false;

        [Required]
        [Display(Name = "Estado")]
        public string Estado { get; set; } // "Pendiente", "En progreso", "Pausada", "Completada"

        [Display(Name = "Tiempo restante (minutos)")]
        public int TiempoRestante => Duracion - TiempoTranscurrido;

        [Display(Name = "Trasladada a siguiente sesión")]
        public bool TrasladadaASiguiente { get; set; } = false;
    }
}