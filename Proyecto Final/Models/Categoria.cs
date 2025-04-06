using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Proyecto_Final.Models
{
    public class Categoria
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Nombre { get; set; } = string.Empty;

        [Required]
        public string Tipo { get; set; } = string.Empty; // "Ingreso" o "Gasto"


        // Relación con ingresos y gastos (opcional si quieres navegabilidad)
        public ICollection<Gasto>? Gastos { get; set; }
        public ICollection<Ingreso>? Ingresos { get; set; }
    }
}
