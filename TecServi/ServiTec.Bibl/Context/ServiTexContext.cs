using ServiTec.Bibl;
using ServiTec.Bibl.Models;
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
        private static string connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDBFileName={
            Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\ServiTecDB.mdf";
        public ServiTexContext()
            : base(connectionString)
        {
        }

        public DbSet<Producto> Productos { get; set; }

        public DbSet<Categoria> Categorias { get; set; }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Orden> Ordenes { get; set; }
        public DbSet<OrdenDetalle> OrdenDetalle { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Bodega> Bodegas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
            System.Data.Entity.Database.SetInitializer(new DatosdeInicio());
        }
    }
}
