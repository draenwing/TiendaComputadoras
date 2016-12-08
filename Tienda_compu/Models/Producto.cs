using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Tienda_compu.Models
{
    public class Producto
    {
        public int Id { get; set; }

        [DisplayName("Nombre")]
        [Required(ErrorMessage = "Es exigido ingresar el nombre de la PC")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "El nombre de la PC no puede ser mayor a 50 caracteres")]
        public String Nombre { get; set; }

        [DisplayName("Marca del PC")]
        [Required(ErrorMessage = "Es requido ingresar la marca de la PC")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "La marca de la PC no puede ser mayor a 60 caracteres")]
        public String Marca { get; set; }

        [DisplayName("Memoria Ram")]
        [Required(ErrorMessage = "Es requido ingresar los valores de la RAM de la PC")]
        [StringLength(70, MinimumLength = 3, ErrorMessage = "La descripcion de la mmoria RAM no puede ser mayor a 70 caracteres")]
        public string Ram { get; set; }

        [DisplayName("Almacenamiento de la PC")]
        [Required(ErrorMessage = "Es requido ingresar las caracteristicas de almacenamiento de la PC")]
        [StringLength(70, MinimumLength = 3, ErrorMessage = "El almacenamiento de la PC no puede ser mayor a 70 caracteres")]
        public string Almacenamiento { get; set; }

        [DisplayName("Peso de la PC")]
       
        [StringLength(20, MinimumLength = 5, ErrorMessage = "el peso no debe ser mayo a 20 caracteres")]
        public string Peso { get; set; }

        [DisplayName("Precio del PC")]
        [Required(ErrorMessage = "Es requido ingresar el precio de la PC")]
        //[StringLength(10, MinimumLength = 5, ErrorMessage = "El precio de la PC no puede ser mayor a los 10 caracteres")]
        public decimal Precio { get; set; }


        public string Color { get; set; }

       

        [DisplayName("URL de la imagen")]
        [DataType(DataType.ImageUrl)]
        [Required(ErrorMessage = "Debe agregar una imagen para el producto")]
        public string ImageUrl { get; set; }

        public String Teclado { get; set; }

        [DisplayName("Tipo de pantalla de la PC")]
        [Required(ErrorMessage = "Es requido ingresar la descripcion de la pantalla de la PC")]
        [StringLength(70, MinimumLength = 3, ErrorMessage = "La descripcion de la pantalla de la PC no puede ser mayor a 70 caracteres")]
        public string TipoPantalla { get; set; }

        public int? CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }

        public virtual ICollection<Image> Images { get; set; }
    }
}