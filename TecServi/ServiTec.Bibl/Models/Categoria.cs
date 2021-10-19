using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ServiTec.Database.Models
{
    public class Categoria
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Ingrese la categoria")]
        public string Descripcion { get; set; }

        public ICollection<Producto> Productos { get; set; }
    }
}