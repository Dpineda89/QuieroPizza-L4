using ServiTec.Bibl.Reportes.Producto.Models;
using ServiTec.Database.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiTec.Bibl.Reportes.Producto
{
    public class VentasPorProductoBl
    {
        ServiTexContext serviTexContext;
        public List<VentasPorProducto>  ListaVentasPorProductos { get; set; }
        public VentasPorProductoBl()
        {
            this.serviTexContext = new ServiTexContext();
            this.ListaVentasPorProductos = new List<VentasPorProducto>();
        }

        public List<VentasPorProducto> ObtenerVentasPorProducto() 
        {
            this.ListaVentasPorProductos = this.serviTexContext.OrdenDetalle
                                                                .Include("Producto")
                                                                .Where(oD => oD.Orden.Activo)
                                                                .GroupBy(oD =>oD.Producto.Descripcion)
                                                                .Select(oD => new VentasPorProducto 
                                                                {
                                                                    Producto= oD.Key,
                                                                    Cantidad = oD.Sum(odd => odd.Cantidad),
                                                                    Total = oD.Sum(odd => odd.Total),
                                                                }).ToList();

            return this.ListaVentasPorProductos;
        }
    }
}
