﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiTec.Database.Models
{
    public class Producto
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }

        public double Precio;
    }
}
