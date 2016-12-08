using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Tienda_compu.Models
{
    public class Carrito
    {
        [Key]
        public int RecordId { get; set; }
        public string CartId { get; set; }
        public int ProductoId { get; set; }
        public int Count { get; set; }
        public System.DateTime DateCreated { get; set; }
        public virtual Producto Producto { get; set; }
    }
}