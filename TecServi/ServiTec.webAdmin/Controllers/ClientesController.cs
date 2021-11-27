using ServiTec.Bibl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ServiTec.webAdmin.Controllers
{
    [Authorize]
    public class ClientesController : Controller
    {
        ClientesBibl _clientesBibL;

        public ClientesController()
        {
            _clientesBibL = new ClientesBibl();
        }


        // GET: Clientes
        public ActionResult Index()
        {
            var listadeClientes = _clientesBibL.ObtenerClientes();

            return View(listadeClientes);
        }

        public ActionResult Crear()
        {
            var nuevoCliente = new Cliente();

            return View(nuevoCliente);
        }

        [HttpPost]
        public ActionResult Crear(Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                _clientesBibL.GuardarCliente(cliente);

                return RedirectToAction("Index");
            }

            return View(cliente);
        }

        public ActionResult Editar(int id)
        {
            var cliente = _clientesBibL.ObtenerCliente(id);

            return View(cliente);
        }

        [HttpPost]
        public ActionResult Editar(Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                _clientesBibL.GuardarCliente(cliente);

                return RedirectToAction("Index");
            }

            return View(cliente);
        }

        public ActionResult Detalle(int id)
        {
            var cliente = _clientesBibL.ObtenerCliente(id);

            return View(cliente);
        }

        public ActionResult Eliminar(int id)
        {
            var cliente = _clientesBibL.ObtenerCliente(id);

            return View(cliente);
        }

        [HttpPost]
        public ActionResult Eliminar(Cliente cliente)
        {
            _clientesBibL.EliminarCliente(cliente.Id);

            return RedirectToAction("Index");
        }
    }
}