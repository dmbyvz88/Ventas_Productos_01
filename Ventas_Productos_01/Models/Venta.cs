using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Ventas_Productos_01.Models
{
    public class Venta
    {
        [Key]
        public int idVenta { get; set; }
        [Required(ErrorMessage = "Este campo es Requerido.")]
        public int idFacturas_Ventas { get; set; }
        //[ForeignKey("idFacturas_Ventas")]
        //[DisplayName("Id Factura")]

        //[Required(ErrorMessage = "Este campo es Requerido.")]
        //[ForeignKey("idProducto")]
        //[DisplayName("Id Producto")]
        //public int idProducto { get; set; }


        //[Required(ErrorMessage = "Este campo es Requerido.")]
        //public int idUsuario { get; set; }
        //[ForeignKey("idUsuario")]
        //[DisplayName("Id Usuario")]
    }
}