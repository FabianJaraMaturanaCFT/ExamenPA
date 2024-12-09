using ExamenPA.Models;
using Microsoft.EntityFrameworkCore;

namespace ExamenPA.Data
{
    public class ExamenDBContext : DbContext
    {
        public ExamenDBContext(DbContextOptions<ExamenDBContext> options) : base(options)
        {
        }
        public DbSet<Proveedor> Proveedores { get; set; }
        public DbSet<TipoProducto> TipoProductos { get; set; }
        public DbSet<Ubicacion> Ubicaciones { get; set; }
    }
}
