using Proyecto_Final.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Proyecto_Final.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Ingreso> Ingresos { get; set; }
        public DbSet<Gasto> Gastos { get; set; }
        public DbSet<Cuenta> Cuentas { get; set; }
        public DbSet<Categoria> Categorias { get; set; } 
    }
}
