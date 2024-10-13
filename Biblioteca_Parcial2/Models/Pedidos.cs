using System.ComponentModel.DataAnnotations;

namespace Biblioteca_Parcial2.Models
{
    public class Pedidos
    {
        [Key]
        
        public int PedidoId { get; set; }

        [Required(ErrorMessage = "El campo Descripción es obligatorio")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "El campo Fecha Pedido es obligatorio")]
        [DataType(DataType.Date, ErrorMessage = "El campo Fecha Pedido debe ser una fecha válida")]
        public DateTime FechaPedido { get; set; }
    }
}
