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
            var categoria = context.Categorias.Add(new Categoria
            {
                Descripcion = "Electronico",
            });

            context.Productos.Add(new Producto
            {
                Descripcion = " Monitor Curvo 24.0 ",
                Precio = 2600.00,
                IdCategoria = categoria.Id,
            });

            context.Productos.Add(new Producto
            {
                Descripcion = " Cable UTP Cat-6 caja 232 Pies ",
                Precio = 1700.00,
                IdCategoria = categoria.Id,
            });

            context.Productos.Add(new Producto
            {
                Descripcion = " Case Army-Z20 Negro 32cm ",
                Precio = 1100.00,
                IdCategoria = categoria.Id,
            });

            context.Productos.Add(new Producto
            {
                Descripcion = " Silla Gamer Full Relax ",
                Precio = 5400.00,
                IdCategoria = categoria.Id,
            });
            context.SaveChanges();
            base.Seed(context);
        }
    }
}
