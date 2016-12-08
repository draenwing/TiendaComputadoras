using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tienda_compu.Models
{
    public class OrdenDetalle
    {
        public int OrdenDetalleId { get; set; }
        public int OrdenId { get; set; }
        public int ProductoId { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public virtual Producto Album { get; set; }
        public virtual Orden Orden { get; set; }
    }
}