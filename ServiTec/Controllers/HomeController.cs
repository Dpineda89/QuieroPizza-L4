using ServiTec.Bibl;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ServiTec.web.Controllers
{
    public class HomeController : Controller
    {
        //GET:Home
        public ActionResult Index()
        {
            var productosBl = new ProductoBibl();
            var listadeProductos = productosBl.ObtenerProductos();
            ViewBag.adminWebSiteUrl = ConfigurationManager.AppSettings["adminWebSiteUrl"];
            return View(listadeProductos);
        }
    }
}