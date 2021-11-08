using ServiTec.Database.Context;
using ServiTec.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiTec.Bibl
{
    public class CategoriaBibl
    {
        ServiTexContext serviTexContext;
        public List<Categoria> ListadeCategorias { get; set; }

        public CategoriaBibl()
        {
            this.serviTexContext = new ServiTexContext();
            this.ListadeCategorias = new List<Categoria>();
        }

        public List<Categoria> ObtenerCategorias()
        {
            var listadecategorias = this.serviTexContext.Categorias.ToList();
            this.ListadeCategorias = listadecategorias;
            return this.ListadeCategorias;
        }

        public Categoria ObtenerCategoria(int id)
        {
            var categoria = this.serviTexContext.Categorias.FirstOrDefault(p => p.Id == id);
            return categoria;
        }

        public bool CrearCategoria(Categoria categoria)
        {
            var exist = this.serviTexContext.Categorias.Any(p => p.Descripcion == categoria.Descripcion);

            if (exist)
            {
                return false;
            }

            try
            {
                this.serviTexContext.Categorias.Add(categoria);
                this.serviTexContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool EliminarCategoria(Categoria categoria)
        {
            var original = this.serviTexContext.Categorias.FirstOrDefault(p => p.Id == categoria.Id);

            if (original == null)
            {
                return false;
            }

            try
            {
                this.serviTexContext.Categorias.Remove(original);
                this.serviTexContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }



        public bool EditarCategoria(Categoria categoria)
        {
            var original = this.serviTexContext.Categorias.FirstOrDefault(p => p.Id == categoria.Id);

            if (original == null)
            {
                return false;
            }

            try
            {
                original.Descripcion = categoria.Descripcion;
                this.serviTexContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
