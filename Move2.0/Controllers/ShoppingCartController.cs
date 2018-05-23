using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Move2._0.Models.ShoppingCart;
using Move2._0.DAL;
namespace Move2._0.Controllers
{
    public class ShoppingCartController : Controller
    {

        private ApplicationDbContext _context;

        public ShoppingCartController() {
            _context = ApplicationDbContext.Create();
        }

        protected override void Dispose(bool dispose) {

            _context.Dispose();
        }

        
        // GET: ShoppingCart
        public ActionResult ShoppingCart()
        {
            var shoppingCart = _context.ShoppingCart.SingleOrDefault();
            return PartialView("_ShoppingCart",shoppingCart);

        }
    }
}