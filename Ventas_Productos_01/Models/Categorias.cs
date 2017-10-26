using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Ventas_Productos_01.Models
{
    public class Categorias
    {
        [Key]
        public int IdCategoria { get; set; }
        [Required(ErrorMessage ="Este campo es Requerido.")]
        [DisplayName("Descripción")]
        public string Descripcion { get; set; }

        public ICollection<Productos> Productos1 { get; set; }
    }
}