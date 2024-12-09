using ExamenPA.Data;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ExamenPA.Models
{
    public class Ubicacion
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es requerido.")]
        [StringLength(100, ErrorMessage = "El nombre no puede exceder los 100 caracteres.")]
        public string Nombre { get; set; }

        public async Task<int> ContarProveedoresAsync(ExamenDBContext context)
        {
            return await context.Proveedores.CountAsync(p => p.UbicacionId == this.Id);
        }
        //public virtual ICollection<Proveedor> Proveedores { get; set; }
    }
}
