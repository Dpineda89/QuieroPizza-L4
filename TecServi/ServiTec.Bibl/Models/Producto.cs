using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiTec.Database.Models
{
    public class Producto
    {
        public Producto()
        {
            this.Activo = true;
        }

        public int Id { get; set; }
        public string Descripcion { get; set; }

        public double Precio { get; set; }

        public Categoria Categoria { get; set; }

        [ForeignKey(nameof(Categoria))]
        public int IdCategoria { get; set; }

        public bool Activo { get; set; }
    }
}
