using ServiTec.Database.Context;
using ServiTec.Database.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiTec.Bibl
{
    public class DatosdeInicio : CreateDatabaseIfNotExists<ServiTexContext>
    {
        protected override void Seed(ServiTexContext context)
        {

            var categoria = context.Categorias.Add(new Categoria
            {
                Descripcion = "Electronico",
            });

            context.Productos.Add(new Producto
            {
                UrlImagen = "~/Imagenes/MSI-G241VC  Curvo 24 FullHD.jpg",
                Descripcion = " Monitor Curvo 24.0 ",
                Precio = 2600.00,
                IdCategoria = categoria.Id,
            });

            context.Productos.Add(new Producto
            {
                UrlImagen = "~/Imagenes/Cable UTP AZUL CAT-5.jpg",
                Descripcion = " Cable UTP Cat-6 caja 232 Pies ",
                Precio = 1700.00,
                IdCategoria = categoria.Id,
            });

            context.Productos.Add(new Producto
            {
                UrlImagen = "~/Imagenes/Case-Negro-702Zh5.jpg",
                Descripcion = " Case Army-Z20 Negro 32cm ",
                Precio = 1100.00,
                IdCategoria = categoria.Id,
            });

            context.Productos.Add(new Producto
            {
                UrlImagen = "~/Imagenes/Silla_Negra y Rojo-Gamer.jpg",
                Descripcion = " Silla Gamer Full Relax ",
                Precio = 5400.00,
                IdCategoria = categoria.Id,
            });

            context.Clientes.Add(new Cliente
            {
                Direccion = "Choloma",
                Nombre = "Ramiro Perez",
                Telefono = "31549099",
            });

            context.Clientes.Add(new Cliente
            {
                Direccion = "San Pedro Sula",
                Nombre = "Domingo Reyes",
                Telefono = "95497521",
            });

            context.Clientes.Add(new Cliente
            {
                Direccion = "Tegucigalpa",
                Nombre = "Armando Asunceri",
                Telefono = "31546875",
            });

            context.SaveChanges();

            var nuevoUsuario = new Usuario();
            nuevoUsuario.Nombre = "admin";
            nuevoUsuario.Contrasena = Encriptar.CodificarContrasena("123");

            context.Usuarios.Add(nuevoUsuario);

            base.Seed(context);
        }
    }
}
