using ServiTec_Pro.web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ServiTec_Pro.Controllers
{
    public class ProductosController : Controller
    {
        // GET: Productos
        public ActionResult Index()
        {
            var producto1 = new ProductosModel();
            producto1.Id = 1;
            producto1.Descripcion = " Monitor Curvo 24.0 ";

            var producto2 = new ProductosModel();
            producto2.Id = 1;
            producto2.Descripcion = " Cable UTP Cat-6 caja 232 Pies ";

            var producto3 = new ProductosModel();
            producto3.Id = 1;
            producto3.Descripcion = " Case Army-Z20 Negro 32cm ";

            var producto4 = new ProductosModel();
            producto4.Id = 1;
            producto4.Descripcion = " Silla Gamer Full Relax ";

            var listadeproductos = new List<ProductosModel>();
            listadeproductos.Add(producto1);
            listadeproductos.Add(producto2);
            listadeproductos.Add(producto3);
            listadeproductos.Add(producto4);

            return View(listadeproductos);
        }
    }
}