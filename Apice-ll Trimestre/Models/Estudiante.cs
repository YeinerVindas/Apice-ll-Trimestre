using System.ComponentModel.DataAnnotations;

namespace Apice_ll_Trimestre.Models
{
    public class Estudiante
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Contrasena { get; set; }
        public string Correo { get; set; }
        public string Conexion { get; set; }
        public int Racha { get; set; }
}
}
