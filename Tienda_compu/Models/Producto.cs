using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tienda_compu.Models
{
    public class Producto
    {
        public int Id { get; set; }
        public String Nombre { get; set; }
        public String Marca { get; set; }
        public string Ram { get; set; }
        public string Almacenamiento { get; set; }
        public string Peso { get; set; }
        public decimal Precio { get; set; }
        public string Color { get; set; }
        public String Teclado { get; set; }
        public string TipoPantalla { get; set; }

        public int? CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }
    }
}