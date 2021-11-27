using ServiTec.Bibl;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace ServiTec.Controllers
{
    public class ProductosController : Controller
    {
        // GET: Productos
        public ActionResult Index()
        {
           var productosBibl = new ProductoBibl();
           var listadeProductos = productosBibl.ObtenerProductos();
            
            return View(listadeProductos);
        }
    }
}