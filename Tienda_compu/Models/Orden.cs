using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Tienda_compu.Models
{
    public class Orden
    {
        [ScaffoldColumn(false)]
        public int OrdenId { get; set; }
        [ScaffoldColumn(false)]
        public string Username { get; set; }
        [Required(ErrorMessage = "El nombre es requerido")]
        [StringLength(255, MinimumLength = 1, ErrorMessage = "El nombre no puede ser mayor a 255 caracteres")]
        [DisplayName("Nombre")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El apellido es requerido")]
        [StringLength(255, MinimumLength = 1, ErrorMessage = "El apellido no puede ser mayor a 255 caracteres")]
        public string Apellido { get; set; }
        [Required(ErrorMessage = "La direccion es requerida")]
        public string Direccion { get; set; }
        [Required(ErrorMessage = "La ciudad es requerida")]
        public string ciudad { get; set; }
       
        [DataType(DataType.PostalCode,ErrorMessage ="Ingrese un codigo postal valido")]
        public int CodigoPostal { get; set; }
        [Required(ErrorMessage = "Country is required")]
        public string Pais { get; set; }
        public string telefono { get; set; }
        [Required(ErrorMessage = "Email Address is required")]
        [DataType(DataType.EmailAddress,ErrorMessage ="Dirección de correo invalida")]
        public string correo { get; set; }
        [ScaffoldColumn(false)]
        public decimal Total { get; set; }
        [ScaffoldColumn(false)]
        public System.DateTime OrderDate { get; set; }
        public List<OrdenDetalle> OrdenDetalles { get; set; }


        
    
    }
}