using ServiTec.Bibl;
using ServiTec.Bibl.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ServiTec.webAdmin.Controllers
{
    [Authorize]
    public class OrdenesDetalleController : Controller
    {
        OrdenesBibl _ordenBibl;
        ProductoBibl _productoBibl;

        public OrdenesDetalleController()
        {
            _ordenBibl = new OrdenesBibl();
            _productoBibl = new ProductoBibl();
        }

        // GET: OrdenesDetalle
        public ActionResult Index(int id)
        {
            var orden = _ordenBibl.ObtenerOrden(id);
            orden.ListadeOrdenDetalle = this._ordenBibl.ObtenerOrdenDetalle(id);
            return View(orden);
        }

        public ActionResult Crear(int id)
        {
            var nuevaOrdenDetalle = new OrdenDetalle();
            nuevaOrdenDetalle.OrdenId = id;

            var productos = _productoBibl.ObtenerProductosActivos();
            ViewBag.ProductoId = new SelectList(productos, "Id", "Descripcion");

            return View(nuevaOrdenDetalle);
        }

        [HttpPost]
        public ActionResult Crear(OrdenDetalle ordenDetalle)
        {
            if (ModelState.IsValid)
            {
                if (ordenDetalle.ProductoId == 0)
                {
                    ModelState.AddModelError("ProductoId", "Seleccione un producto");
                    var productos1 = _productoBibl.ObtenerProductosActivos();
                    ViewBag.ProductoId = new SelectList(productos1, "Id", "Descripcion");
                    return View(ordenDetalle);
                }

                _ordenBibl.GuardarOrdenDetalle(ordenDetalle);
                return RedirectToAction("Index", new { id = ordenDetalle.OrdenId });
            }

            var productos = _productoBibl.ObtenerProductosActivos();
            ViewBag.ProductoId = new SelectList(productos, "Id", "Descripcion");

            return View(ordenDetalle);
        }

        public ActionResult Eliminar(int id)
        {
            var ordenDetalle = _ordenBibl.ObtenerOrdenDetallePorId(id);

            return View(ordenDetalle);
        }

        [HttpPost]
        public ActionResult Eliminar(OrdenDetalle ordenDetalle)
        {
            _ordenBibl.EliminarOrdenDetalle(ordenDetalle.Id);

            return RedirectToAction("Index", new { id = ordenDetalle.OrdenId });
        }
    }
}