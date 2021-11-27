using ServiTec.Bibl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ServiTec.webAdmin.Controllers
{
    public class BodegasController : Controller
    {
        BodegasBibl _bodegasBibl;

        public BodegasController()
        {
            _bodegasBibl = new BodegasBibl();
        }
        // GET: Bodegas
        public ActionResult Index()
        {
            var listadeBodegas = _bodegasBibl.ObtenerBodegas();

            return View(listadeBodegas);
        }

        public ActionResult Crear()
        {
            var nuevaBodega = new Bodega();

            return View(nuevaBodega);
        }

        [HttpPost]
        public ActionResult Crear(Bodega bodega)
        {
            if (ModelState.IsValid)
            {
                if (bodega.Descripcion != bodega.Descripcion.Trim())
                {
                    ModelState.AddModelError("Descripcion", "La descripción no debe contener espacios al inicio o al final");
                    return View(bodega);
                }

                _bodegasBibl.GuardarBodega(bodega);

                return RedirectToAction("Index");
            }

            return View(bodega);
        }

        public ActionResult Editar(int id)
        {
            var bodega = _bodegasBibl.ObtenerBodega(id);

            return View(bodega);
        }

        [HttpPost]
        public ActionResult Editar(Bodega bodega)
        {
            if (ModelState.IsValid)
            {
                if (bodega.Descripcion != bodega.Descripcion.Trim())
                {
                    ModelState.AddModelError("Descripcion", "La descripción no debe contener espacios al inicio o al final");
                    return View(bodega);
                }

                _bodegasBibl.GuardarBodega(bodega);

                return RedirectToAction("Index");
            }

            return View(bodega);
        }

        public ActionResult Detalle(int id)
        {
            var bodega = _bodegasBibl.ObtenerBodega(id);

            return View(bodega);
        }

        public ActionResult Eliminar(int id)
        {
            var bodega = _bodegasBibl.ObtenerBodega(id);

            return View(bodega);
        }

        [HttpPost]
        public ActionResult Eliminar(Bodega bodega)
        {
            _bodegasBibl.EliminarBodega(bodega.Id);

            return RedirectToAction("Index");
        }
    }
}