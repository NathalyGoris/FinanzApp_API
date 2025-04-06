using System.ComponentModel.DataAnnotations;

namespace Proyecto_Final.Models
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string Nombre { get; set; }

        [Required, MaxLength(100)]
        public string Email { get; set; }

        [Required]
        public string Contraseña { get; set; }

        public DateTime FechaRegistro { get; set; } = DateTime.Now;
    }
}
