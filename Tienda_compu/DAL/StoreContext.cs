using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tienda_compu.Models;
using System.Data.Entity;

namespace Tienda_compu.DAL
{
    public class StoreContext:DbContext
    {
        public DbSet<Producto> Producto { get; set; }
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Carrito> Carritos { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Orden> Ordenes { get; set; }
        public DbSet<OrdenDetalle> OrdenDetalles { get; set; }

        public System.Data.Entity.DbSet<Tienda_compu.ViewModels.ShoppingCartViewModel> ShoppingCartViewModels { get; set; }
    }
}