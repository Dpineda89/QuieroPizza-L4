using ServiTec.Database.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiTec.Bibl
{
    public class BodegasBibl
    {
        ServiTexContext serviTexContext;
        public List<Bodega> ListadeBodegas { get; set; }

        public BodegasBibl()
        {
            serviTexContext = new ServiTexContext();
            ListadeBodegas = new List<Bodega>();
        }

        public List<Bodega> ObtenerBodegas()
        {
            ListadeBodegas = serviTexContext.Bodegas.ToList();
            return ListadeBodegas;
        }

        public void GuardarBodega(Bodega bodega)
        {
            if (bodega.Id == 0)
            {
                serviTexContext.Bodegas.Add(bodega);
            }
            else
            {
                var bodegaExistente = serviTexContext.Bodegas.Find(bodega.Id);
                bodegaExistente.Descripcion = bodega.Descripcion;
            }

            serviTexContext.SaveChanges();
        }

        public Bodega ObtenerBodega(int id)
        {
            var bodega = serviTexContext.Bodegas.Find(id);

            return bodega;
        }

        public void EliminarBodega(int id)
        {
            var bodega = serviTexContext.Bodegas.Find(id);

            serviTexContext.Bodegas.Remove(bodega);
            serviTexContext.SaveChanges();
        }
    }
}
