using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        [Range(1, 16, ErrorMessage = "El número de bloques debe estar entre 1 y 16.")]
        [Display(Name = "Cantidad de bloques (Pomodoros)")]
        public int CantidadBloques { get; set; }

        [Display(Name = "Bloque actual")]
        public int BloqueActual { get; set; } = 1;

        [Display(Name = "En descanso")]
        public bool EnDescanso { get; set; } = false;

        [Display(Name = "Tiempo transcurrido (minutos)")]
        public int TiempoTranscurrido { get; set; } = 0;

        [Display(Name = "Completada")]
        public bool Completada { get; set; } = false;

        [Required]
        [Display(Name = "Estado")]
        public string Estado { get; set; } // "Pendiente", "En progreso", "Pausada", "Completada"

        [Display(Name = "Trasladada a siguiente sesión")]
        public bool TrasladadaASiguiente { get; set; } = false;

        // Calculadas
        [NotMapped]
        public int DuracionTotal => CantidadBloques * 25; // minutos de estudio puro

        [NotMapped]
        public int DescansoTotal => (CantidadBloques - 1) * 5; // descansos entre bloques

        [NotMapped]
        public int TiempoTotalSesion => DuracionTotal + DescansoTotal;

        [NotMapped]
        public int TiempoRestante => TiempoTotalSesion - TiempoTranscurrido;

        [NotMapped]
        public int BloquesCompletados => TiempoTranscurrido / 30; // 25 estudio + 5 descanso
    }
}