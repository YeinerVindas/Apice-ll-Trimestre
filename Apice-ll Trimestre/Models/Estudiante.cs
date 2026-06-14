using System.ComponentModel.DataAnnotations;

namespace Apice_ll_Trimestre.Models
{
    public class Estudiante
    {
        public int ID { get; set; }

        [Required]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Correo")]
        public string Correo { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Contraseña")]
        public string Contrasena { get; set; }

        [Display(Name = "Fecha de conexión")]
        public DateTime? FechaConexion { get; set; }

        private int? _rachaActual;

        [Display(Name = "Foto de perfil")]
        public string FotoPerfil { get; set; } // ruta o URL de la imagen

        [Display(Name = "Racha actual")]
        public int? RachaActual
        {
            get => _rachaActual;
            set => _rachaActual = (value.HasValue && value < 0) ? 0 : value;
        }
    }
}
