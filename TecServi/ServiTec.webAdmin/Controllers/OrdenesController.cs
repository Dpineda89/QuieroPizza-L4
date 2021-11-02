using ServiTec.Bibl;
using ServiTec.Bibl.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ServiTec.webAdmin.Controllers
{
    public class OrdenesController : Controller
    {
        OrdenesBibl _ordenesBibl;
        ClientesBibl _clientesBibl;

        public OrdenesController()
        {
            _ordenesBibl = new OrdenesBibl();
            _clientesBibl = new ClientesBibl();
        }

        // GET: Ordenes
        public ActionResult Index()
        {
            var listadeOrdenes = _ordenesBibl.ObtenerOrdenes();

            return View(listadeOrdenes);
        }
        public ActionResult Crear()
        {
            var nuevaOrden = new Orden();
            var clientes = _clientesBibl.ObtenerClientesActivos();

            ViewBag.ClienteId = new SelectList(clientes, "Id", "Nombre");

            return View(nuevaOrden);
        }

        [HttpPost]
        public ActionResult Crear(Orden orden)
        {
            if (ModelState.IsValid)
            {
                if (orden.ClienteId == 0)
                {
                    ModelState.AddModelError("ClienteId", "Seleccione un cliente");
                    return View(orden);
                }

                _ordenesBibl.GuardarOrden(orden);

                return RedirectToAction("Index");
            }

            var clientes = _clientesBibl.ObtenerClientesActivos();

            ViewBag.ClienteId = new SelectList(clientes, "Id", "Nombre");

            return View(orden);
        }

        public ActionResult Editar(int id)
        {
            var orden = _ordenesBibl.ObtenerOrden(id);
            var clientes = _clientesBibl.ObtenerClientesActivos();

            ViewBag.ClienteId = new SelectList(clientes, "Id", "Nombre", orden.ClienteId);

            return View(orden);
        }

        [HttpPost]
        public ActionResult Editar(Orden orden)
        {
            if (ModelState.IsValid)
            {
                if (orden.ClienteId == 0)
                {
                    ModelState.AddModelError("ClienteId", "Seleccione un cliente");
                    var clientes1 = _clientesBibl.ObtenerClientesActivos();
                    ViewBag.ClienteId = new SelectList(clientes1, "Id", "Nombre", orden.ClienteId);
                    return View(orden);
                }

                _ordenesBibl.GuardarOrden(orden);

                return RedirectToAction("Index");
            }

            var clientes = _clientesBibl.ObtenerClientesActivos();

            ViewBag.ClienteId = new SelectList(clientes, "Id", "Nombre", orden.ClienteId);

            return View(orden);
        }

        public ActionResult Detalle(int id)
        {
            var orden = _ordenesBibl.ObtenerOrden(id);
            return View(orden);
        }


        [HttpPost]
        public ActionResult Eliminar(Orden orden)
        {
            var result = this._ordenesBibl.EliminarOrden(orden);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public ActionResult Eliminar(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }

            var orden = this._ordenesBibl.ObtenerOrden(id.Value);

            if (orden == null)
            {
                return RedirectToAction("Index");
            }

            return this.View(orden);
        }

    }
}