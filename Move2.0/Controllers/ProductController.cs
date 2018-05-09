using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Move2._0.DAL;
using System.Data.Entity;
using Move2._0.Models.Move;
using Move2._0.Models.ShoppingCart;
using Move2._0.ViewModel.ShoppingCart;


namespace Move2._0.Controllers
{
    public class ProductController : Controller
    {
        
        private ApplicationDbContext _context=null;

        public ProductController() {
            _context = ApplicationDbContext.Create();
        }

        protected override void Dispose(bool disposing)

        {
            _context.Dispose();

        }


        // GET: Product
        public ActionResult Index()
        {
            var products = _context.Producto.Include(f=>f.Features).ToList();
            var features = _context.Feature.ToList();

            var productIndexViewModel = new ProductIndexViewModel()
            {
                Features = features,
                Productos = products
            };
            return View("Productos", productIndexViewModel);
        }
    }
}