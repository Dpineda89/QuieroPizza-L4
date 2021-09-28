using ServiTec.Database.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiTec.Bibl
{
    public class ReporteVentasPorProductoBibl
    {
        ServiTexContext serviTexContext;
        public List<ReporteVetasPorProducto> ListadeVentasPorProducto { get; set; }

        public ReporteVentasPorProductoBibl()
        {
            serviTexContext = new ServiTexContext();
        }

        public List<ReporteVetasPorProducto> ObtenerVetasPorProducto()
        {
            ListadeVentasPorProducto = serviTexContext.OrdenDetalle
                .Include("Producto")
                .Where(p => p.Orden.Activo)
                .GroupBy(p => p.Producto.Descripcion)
                .Select(p => new ReporteVetasPorProducto()
                {
                    Producto = p.Key,
                    Cantidad = p.Sum(s => s.Cantidad),
                    Total = p.Sum(s => s.Total)
                }).ToList();

            return ListadeVentasPorProducto;

        }
    }

}
