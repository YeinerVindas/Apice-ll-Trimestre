using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Apice_ll_Trimestre.Models
{
    public class Tareas
    {
        public int ID { get; set; }

        [Required]
        [Display(Name = "Estudiante")]
        public int ID_Estudiante { get; set; }

        [Required]
        [Display(Name = "Título")]
        public string Titulo { get; set; }

        [Display(Name = "Descripción")]
        public string Descripcion { get; set; }

        [Required]
        [Display(Name = "Estado")]
        public string Estado { get; set; }

        [Required]
        [Display(Name = "Fecha de entrega")]
        public DateTime FechaEntrega { get; set; }

        [Display(Name = "Fecha de creación")]
        public DateTime FechaCreacion { get; set; } = DateTime.Now;

        [NotMapped]
        [Display(Name = "Días restantes")]
        public int DiasRestantes => (FechaEntrega - DateTime.Today).Days;

        [NotMapped]
        public bool EstaProxima => DiasRestantes <= 3 && DiasRestantes >= 0;

        [NotMapped]
        public bool EstaVencida => DiasRestantes < 0;
    }
}