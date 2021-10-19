using System.Collections.Generic;
<<<<<<< HEAD
using System.ComponentModel.DataAnnotations;
=======
>>>>>>> 0a23368ca8414b2a368072991d98d41a904b86f1

namespace ServiTec.Database.Models
{
    public class Categoria
    {
        public int Id { get; set; }

<<<<<<< HEAD
        [Required(ErrorMessage ="Ingrese la categoria")]
=======
>>>>>>> 0a23368ca8414b2a368072991d98d41a904b86f1
        public string Descripcion { get; set; }

        public ICollection<Producto> Productos { get; set; }
    }
}