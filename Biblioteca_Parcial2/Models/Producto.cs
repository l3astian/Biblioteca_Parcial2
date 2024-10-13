using System.ComponentModel.DataAnnotations;

namespace Biblioteca_Parcial2.Models
{
    public class Producto
    {
        [Key]
        public int ProductoId { get; set; }

        [Required(ErrorMessage = "El campo Nombre es obligatorio")]
        [MaxLength(100, ErrorMessage = "El campo Nombre no puede tener más de 100 caracteres")]
        public string Nombre { get; set; }

        [Range(0.01, double.MaxValue, ErrorMessage = "El Precio debe ser un valor positivo")]
        public decimal Precio { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "La Cantidad debe ser mayor o igual a 0")]
        public decimal Cantidad { get; set; }
    }
}
