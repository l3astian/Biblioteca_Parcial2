using System.ComponentModel.DataAnnotations;

namespace Biblioteca_Parcial2.Models
{
    public class Clientes
    {
        [Key]
        public int ClienteId { get; set; }

        [Required(ErrorMessage = "El campo Nombre es obligatorio")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "El Nombre debe tener entre 3 y 100 caracteres")]
        public string NombreCliente { get; set; }

        [Required(ErrorMessage = "El campo Correo Electrónico es obligatorio")]
        [EmailAddress(ErrorMessage = "El campo Correo Electrónico no es una dirección válida")]
        public string CorreoElectronico { get; set; }

        [Required(ErrorMessage = "El campo Teléfono es obligatorio")]
        [RegularExpression(@"\d{8}", ErrorMessage = "El Teléfono debe tener exactamente 8 dígitos")]
        public string Telefono { get; set; }
    }
}
