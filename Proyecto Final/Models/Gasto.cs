﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Proyecto_Final.Models
{
    public class Gasto
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int UsuarioId { get; set; }

        [Required]
        public int CuentaId { get; set; }

        [Required, Column(TypeName = "decimal(18,2)")]
        public decimal Monto { get; set; }

        [Required, MaxLength(100)]
        public string Categoria { get; set; }

        [Required]
        public DateTime Fecha { get; set; } = DateTime.Now;

        public string? Descripcion { get; set; }

        public Usuario Usuario { get; set; }
        public Cuenta Cuenta { get; set; }
    }
}
