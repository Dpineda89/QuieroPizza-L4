using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        [Display(Name = "Descripción")]
        [Required(ErrorMessage = "Ingrese la descripción")]
        [MinLength(3, ErrorMessage = "Ingrese minimo 3 caracteres")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "Ingrese la precio")]
        [Range(0, 100000000000000, ErrorMessage = "Ingrese un valor mayor a 0")]
        public double Precio { get; set; }

        public Categoria Categoria { get; set; }

        [ForeignKey(nameof(Categoria))]
        public int IdCategoria { get; set; }

        [Display(Name ="Imagen")]
        public String UrlImagen { get; set; }

        public bool Activo { get; set; }
    }
}
