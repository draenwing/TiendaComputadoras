using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tienda_compu.Models;

namespace Tienda_compu.ViewModels
{
    public class ShoppingCartViewModel
    {
        public int Id { get; set; }
        public List<Carrito> CartItems { get; set; }
        public decimal CartTotal { get; set; }
    }
}