using ServiTec.Database.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiTec.Database.Context
{
    public class ServiTexContext : DbContext
    {
        private static string connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDBFileName={Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\ServiTecDB.mdf";
        public ServiTexContext()
            : base(connectionString)
        {
        }

        public DbSet<Producto> Productos { get; set; }

<<<<<<< HEAD
        public DbSet<Categoria> Categorias { get; set; }

=======
>>>>>>> 0a23368ca8414b2a368072991d98d41a904b86f1
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
}
