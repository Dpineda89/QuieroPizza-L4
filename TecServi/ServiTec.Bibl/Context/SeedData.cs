using ServiTec.Database.Context;
using ServiTec.Database.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiTec.Bibl.Context
{
    public class SeedData : DropCreateDatabaseIfModelChanges<ServiTexContext>
    {
        protected override void Seed(ServiTexContext context)
        {
<<<<<<< HEAD
            var categoria = context.Categorias.Add(new Categoria
            {
                Descripcion = "Electronico",
            });
=======
>>>>>>> 0a23368ca8414b2a368072991d98d41a904b86f1

            context.Productos.Add(new Producto
            {
                Descripcion = " Monitor Curvo 24.0 ",
<<<<<<< HEAD
                Precio = 2600.00,
                IdCategoria = categoria.Id,
=======
                Precio = 2600.00
>>>>>>> 0a23368ca8414b2a368072991d98d41a904b86f1
            });

            context.Productos.Add(new Producto
            {
                Descripcion = " Cable UTP Cat-6 caja 232 Pies ",
<<<<<<< HEAD
                Precio = 1700.00,
                IdCategoria = categoria.Id,
=======
                Precio = 1700.00
>>>>>>> 0a23368ca8414b2a368072991d98d41a904b86f1
            });

            context.Productos.Add(new Producto
            {
                Descripcion = " Case Army-Z20 Negro 32cm ",
<<<<<<< HEAD
                Precio = 1100.00,
                IdCategoria = categoria.Id,
=======
                Precio = 1100.00
>>>>>>> 0a23368ca8414b2a368072991d98d41a904b86f1
            });

            context.Productos.Add(new Producto
            {
                Descripcion = " Silla Gamer Full Relax ",
<<<<<<< HEAD
                Precio = 5400.00,
                IdCategoria = categoria.Id,
=======
                Precio = 5400.00
>>>>>>> 0a23368ca8414b2a368072991d98d41a904b86f1
            });
            context.SaveChanges();
            base.Seed(context);
        }
    }
}
