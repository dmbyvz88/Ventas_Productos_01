using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Ventas_Productos_01.Models
{
    public class Productos
    {
        [Key]
        public int idProducto { get; set; }
        [Required(ErrorMessage = "Este campo es Requerido.")]
        [DisplayName("Nombre Producto")]
        public string Nombre_Producto { get; set; }
        [Required(ErrorMessage = "Este campo es Requerido.")]
        [DisplayName("Cantidad")]
        public float Cantidad { get; set; }
        [Required(ErrorMessage = "Este campo es Requerido.")]
        [DisplayName("Precio")]
        public float Precio { get; set; }

        [Required(ErrorMessage = "Este campo es Requerido.")]
        public int idCategoria { get; set; }
        [ForeignKey("idCategoria")]
        [DisplayName("Id Categoria")]
        public virtual Categorias Categoria { get; set; }

        //public ICollection<Venta> Ventas { get; set; }
    }
}