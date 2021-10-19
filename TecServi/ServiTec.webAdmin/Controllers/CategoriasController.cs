using ServiTec.Bibl;
using ServiTec.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ServiTec.webAdmin.Controllers
{
    public class CategoriasController : Controller
    {
        CategoriaBibl _categoriasBibl;
        public CategoriasController()
        {
            _categoriasBibl = new CategoriaBibl();
        }


        // GET: Categorias
        public ActionResult Index()
        {
            var listadeCategorias = _categoriasBibl.ObtenerCategorias();

            return View(listadeCategorias);
        }

        public ActionResult Crear()
        {
            var nuevoCategoria = new Categoria();
            return View(nuevoCategoria);
        }


        [HttpPost]
        public ActionResult Crear(Categoria categoria)
        {
            if (ModelState.IsValid)
            {
                if (categoria.Descripcion != categoria.Descripcion.Trim())
                {
                    ModelState.AddModelError("Descripcion", "La Descripción no debe contener espacios al inicio o al final");

                    return View(categoria);
                }

                var result = this._categoriasBibl.CrearCategoria(categoria);
                return RedirectToAction("Index");
            }

            return View(categoria);
        }


        [HttpPost]
        public ActionResult Editar(Categoria categoria)
        {
            if (ModelState.IsValid)
            {
                if (categoria.Descripcion != categoria.Descripcion.Trim())
                {
                    ModelState.AddModelError("Descripcion", "La Descripción no debe contener espacios al inicio o al final");

                    return View(categoria);
                }

                var result = this._categoriasBibl.EditarCategoria(categoria);
                return RedirectToAction("Index");
            }

            return View(categoria);
        }

        [HttpPost]
        public ActionResult Eliminar(Categoria categoria)
        {
            var result = this._categoriasBibl.EliminarCategoria(categoria);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Editar(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }

            var categoria = this._categoriasBibl.ObtenerCategoria(id.Value);

            if (categoria == null)
            {
                return RedirectToAction("Index");
            }

            return this.View(categoria);
        }

        [HttpGet]
        public ActionResult Detalle(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }

            var categoria = this._categoriasBibl.ObtenerCategoria(id.Value);

            if (categoria == null)
            {
                return RedirectToAction("Index");
            }

            return this.View(categoria);
        }


        [HttpGet]
        public ActionResult Eliminar(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }

            var categoria = this._categoriasBibl.ObtenerCategoria(id.Value);

            if (categoria == null)
            {
                return RedirectToAction("Index");
            }

            return this.View(categoria);
        }
    }
}