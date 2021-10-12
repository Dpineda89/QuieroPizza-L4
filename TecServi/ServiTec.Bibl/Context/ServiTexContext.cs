﻿using ServiTec.Database.Models;
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

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
}
