using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiTec.Bibl
{
    public class ProductoBl
    {
        List<Producto> ObtenerProductos()
        {
            var producto1 = new Producto();
            producto1.Id = 1;
            producto1.Descripcion = " Monitor Curvo 24.0 ";

            var producto2 = new Producto();
            producto2.Id = 1;
            producto2.Descripcion = " Cable UTP Cat-6 caja 232 Pies ";

            var producto3 = new Producto();
            producto3.Id = 1;
            producto3.Descripcion = " Case Army-Z20 Negro 32cm ";

            var producto4 = new Producto();
            producto4.Id = 1;
            producto4.Descripcion = " Silla Gamer Full Relax ";

            var listadeproductos = new List<Producto>();
            listadeproductos.Add(producto1);
            listadeproductos.Add(producto2);
            listadeproductos.Add(producto3);
            listadeproductos.Add(producto4);

            return listadeproductos;
        }
    }
}
