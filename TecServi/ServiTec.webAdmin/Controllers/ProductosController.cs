﻿using ServiTec.Bibl;
using ServiTec.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ServiTec.webAdmin.Controllers
{
    public class ProductosController : Controller
    {
        ProductoBibl _productosBibl;
        CategoriaBibl _categoriaBibl;
        public ProductosController()
        {
            _productosBibl = new ProductoBibl();
            this._categoriaBibl = new CategoriaBibl();
        }


        // GET: Productos
        public ActionResult Index()
        {
            var listadeProductos = _productosBibl.ObtenerProductos();

            return View(listadeProductos);
        }

        public ActionResult Crear()
        {
            var nuevoProducto = new Producto();
            var categorias = this._categoriaBibl.ObtenerCategorias();

            ViewBag.IdCategoria = new SelectList(categorias, "Id", "Descripcion");
            return View(nuevoProducto);
        }


        [HttpPost]
        public ActionResult Crear(Producto producto)
        {
            var result = this._productosBibl.CrearProducto(producto);
            return RedirectToAction("Index");
        }


        [HttpPost]
        public ActionResult Editar(Producto producto)
        {
            var result = this._productosBibl.EditarProducto(producto);
            return RedirectToAction("Index");
        }



        [HttpPost]
        public ActionResult Eliminar(Producto producto)
        {
            var result = this._productosBibl.EliminarProducto(producto);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Editar(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }

            var producto = this._productosBibl.ObtenerProducto(id.Value);

            if (producto == null)
            {
                return RedirectToAction("Index");
            }

            var categorias = this._categoriaBibl.ObtenerCategorias();

            ViewBag.IdCategoria = new SelectList(categorias, "Id", "Descripcion");
            return this.View(producto);
        }

        [HttpGet]
        public ActionResult Detalle(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }

            var producto = this._productosBibl.ObtenerProducto(id.Value);

            if (producto == null)
            {
                return RedirectToAction("Index");
            }

            return this.View(producto);
        }


        [HttpGet]
        public ActionResult Eliminar(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }

            var producto = this._productosBibl.ObtenerProducto(id.Value);

            if (producto == null)
            {
                return RedirectToAction("Index");
            }

            return this.View(producto);
        }
    }
}