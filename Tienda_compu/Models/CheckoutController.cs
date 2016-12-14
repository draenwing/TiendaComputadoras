using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tienda_compu.DAL;

namespace Tienda_compu.Models
{
    public class CheckoutController : Controller
    {
        StoreContext storeDB = new StoreContext();

        const string PromoCode = "FREE";
        private bool active = true;

        //
        // GET: /Checkout/AddressAndPayment
        public ActionResult AddressAndPayment()
        {
            return View();
        }
        //
        // POST: /Checkout/AddressAndPayment
        [HttpPost]
        public ActionResult AddressAndPayment(FormCollection values)
        {
            var order = new Orden();
            TryUpdateModel(order);
            var cart = new ShoppingCart();

            try
            {
                if (string.Equals(values["PromoCode"], PromoCode,
                    StringComparison.OrdinalIgnoreCase) == false)
                {
                    cart.EmptyCart();
                    return RedirectToAction("Complete",
                        new { id = order.OrdenId });
                }
                else
                {
                    //order.Nombre = User.Identity.Name;
                    //order.OrderDate = DateTime.Now;

                    ////Save Order


                    //storeDB.Ordenes.Add(order);
                    //storeDB.SaveChanges();

                    //Process the order


                    //var cart = ShoppingCart.GetCart(this.HttpContext);
                    //cart.CreateOrder(order);
                    cart.EmptyCart();
                    return RedirectToAction("Complete",
                        new { id = order.OrdenId });
                }
            }
            catch
            {
                //Invalid - redisplay with errors
                return View(order);
            }
        }


        //
        // GET: /Checkout/Complete
        [ValidateAntiForgeryToken]
        public ActionResult Complete(int id)
        {
            // Validate customer owns this order
            bool isValid = true;
                

            if (isValid)
            {
                return View(id);
            }
            else
            {
                return View("Error");
            }
        }
    }
}