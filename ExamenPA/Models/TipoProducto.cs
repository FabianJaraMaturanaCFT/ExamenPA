using System.ComponentModel.DataAnnotations;

namespace ExamenPA.Models
{
    public class TipoProducto
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es requerido.")]
        [StringLength(100, ErrorMessage = "El nombre no puede exceder los 100 caracteres.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "La descripción del producto es obligatoria.")]
        [StringLength(100, ErrorMessage = "La descripción no puede exceder los 300 caracteres.")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "El estado es requerido.")]
        [RegularExpression("^(Disponible|No Disponible)$", ErrorMessage = "El estado debe ser 'Disponible' o 'No Disponible'.")]
        public string Estado { get; set; } 
    }
}
