using System.Collections.Generic;

namespace ServiTec.Database.Models
{
    public class Categoria
    {
        public int Id { get; set; }

        public string Descripcion { get; set; }

        public ICollection<Producto> Productos { get; set; }
    }
}