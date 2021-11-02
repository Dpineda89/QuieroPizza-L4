using ServiTec.Database.Context;
using ServiTec.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiTec.Bibl
{
    public class ProductoBibl
    {
        ServiTexContext serviTexContext;
        public List<Producto> ListadeProductos { get; set; }

        public ProductoBibl()
        {
            this.serviTexContext = new ServiTexContext();
            this.ListadeProductos = new List<Producto>();
        }

        public List<Producto> ObtenerProductos()
        {
<<<<<<< HEAD
            var listadeproductos = this.serviTexContext.Productos
                .Include("Categoria")
                .ToList();
            this.ListadeProductos = listadeproductos;
            return this.ListadeProductos;
        }

        public Producto ObtenerProducto(int id)
        {
            var producto = this.serviTexContext.Productos
                .Include("Categoria")
                .FirstOrDefault(p => p.Id == id);

            return producto;
        }

        public bool CrearProducto(Producto producto)
        {
            var exist = this.serviTexContext.Productos.Any(p => p.Descripcion == producto.Descripcion);

            if (exist)
            {
                return false;
            }

            try
            {
                this.serviTexContext.Productos.Add(producto);
                this.serviTexContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool EliminarProducto(Producto producto)
        {
            var original = this.serviTexContext.Productos.FirstOrDefault(p => p.Id == producto.Id);

            if (original == null)
            {
                return false;
            }

            try
            {
                this.serviTexContext.Productos.Remove(original);
                this.serviTexContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }



        public bool EditarProducto(Producto producto)
        {
            var original = this.serviTexContext.Productos.FirstOrDefault(p => p.Id == producto.Id);

            if (original == null)
            {
                return false;
            }

            try
            {
                original.Descripcion = producto.Descripcion;
                original.Precio = producto.Precio;
                original.IdCategoria = producto.IdCategoria;
                this.serviTexContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool GuardarProducto(Producto producto)
        {
            var original = this.serviTexContext.Productos.FirstOrDefault(p => p.Id == producto.Id);

            if (original == null)
            {
                return false;
            }

            try
            {
                original.Descripcion = producto.Descripcion;
                original.IdCategoria = producto.IdCategoria;
                original.Precio = producto.Precio;
                original.UrlImagen = producto.UrlImagen;
                this.serviTexContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
=======
            var listadeproductos = this.serviTexContext.Productos.ToList();
            this.ListadeProductos = listadeproductos;
            return this.ListadeProductos;
        }
>>>>>>> 0a23368ca8414b2a368072991d98d41a904b86f1
    }
}
