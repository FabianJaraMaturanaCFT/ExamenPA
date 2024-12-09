using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExamenPA.Models
{
    public class Proveedor
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio. Por favor, ingresa tu RUT.")]
        [StringLength(50, ErrorMessage = "El RUT ingresado no es válido. Por favor, asegúrate de que siga el formato correcto (12.345.678-9)")]
        public string Rut { get; set; }

        [Required(ErrorMessage = "El nombre es requerido.")]
        [StringLength(100, ErrorMessage = "El nombre no puede exceder los 100 caracteres.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "La ubicación asociada es requerida.")]
        [ForeignKey("Ubicacion")]
        public int UbicacionId { get; set; } 
        //public virtual Ubicacion Ubicacion { get; set; }
    }
}
