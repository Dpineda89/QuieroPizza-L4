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
            var listadeproductos = this.serviTexContext.Productos.ToList();
            this.ListadeProductos = listadeproductos;
            return this.ListadeProductos;
        }
    }
}
