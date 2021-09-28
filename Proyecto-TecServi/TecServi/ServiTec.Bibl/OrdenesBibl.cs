using ServiTec.Bibl.Models;
using ServiTec.Database.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiTec.Bibl
{
    public class OrdenesBibl
    {
        ServiTexContext _ServiTexContext;
        public List<Orden> ListadeOrdenes { get; set; }

        public OrdenesBibl()
        {
            _ServiTexContext = new ServiTexContext();
            ListadeOrdenes = new List<Orden>();
        }

        public List<Orden> ObtenerOrdenes()
        {
            ListadeOrdenes = _ServiTexContext.Ordenes
                .Include("Cliente")
                .ToList();

            return ListadeOrdenes;
        }

        public List<OrdenDetalle> ObtenerOrdenDetalle(int ordenId)
        {
            var listadeOrdenesDetalle = _ServiTexContext.OrdenDetalle
                .Include("Producto")
                .Where(o => o.OrdenId == ordenId).ToList();

            return listadeOrdenesDetalle;
        }

        public OrdenDetalle ObtenerOrdenDetallePorId(int id)
        {
            var ordenDetalle = _ServiTexContext.OrdenDetalle
                .Include("Producto").FirstOrDefault(p => p.Id == id);

            return ordenDetalle;
        }

        public Orden ObtenerOrden(int id)
        {
            var orden = _ServiTexContext.Ordenes
                .Include("Cliente")
                    .FirstOrDefault(p => p.Id == id);

            return orden;
        }

        public void GuardarOrden(Orden orden)
        {
            if (orden.Id == 0)
            {
                _ServiTexContext.Ordenes.Add(orden);
            }
            else
            {
                var ordenExistente = _ServiTexContext.Ordenes.Find(orden.Id);
                ordenExistente.ClienteId = orden.ClienteId;
                ordenExistente.Activo = orden.Activo;
            }

            _ServiTexContext.SaveChanges();
        }

        public void GuardarOrdenDetalle(OrdenDetalle ordenDetalle)
        {
            var producto = _ServiTexContext.Productos.Find(ordenDetalle.ProductoId);

            ordenDetalle.Precio = producto.Precio;
            ordenDetalle.Total = ordenDetalle.Cantidad * ordenDetalle.Precio;

            _ServiTexContext.OrdenDetalle.Add(ordenDetalle);

            var orden = _ServiTexContext.Ordenes.Find(ordenDetalle.OrdenId);
            orden.Total = orden.Total + ordenDetalle.Total;

            _ServiTexContext.SaveChanges();
        }

        public void EliminarOrdenDetalle(int id)
        {
            var ordenDetalle = _ServiTexContext.OrdenDetalle.Find(id);
            _ServiTexContext.OrdenDetalle.Remove(ordenDetalle);

            var orden = _ServiTexContext.Ordenes.Find(ordenDetalle.OrdenId);
            orden.Total = orden.Total - ordenDetalle.Total;

            _ServiTexContext.SaveChanges();
        }

        public bool EliminarOrden(Orden orden)
        {
            var original = this._ServiTexContext.Ordenes.FirstOrDefault(p => p.Id == orden.Id);

            if (original == null)
            {
                return false;
            }

            try
            {
                this._ServiTexContext.Ordenes.Remove(original);
                this._ServiTexContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


    }
}
