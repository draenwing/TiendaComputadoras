using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Tienda_compu.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        [DisplayName("Nombre categoria")]
        [Required(ErrorMessage = "Es requido ingresar el nombre de la categoria")]
        public string Nombre { get; set; }
        public virtual ICollection<Producto> Productos { get; set; }


    }
}