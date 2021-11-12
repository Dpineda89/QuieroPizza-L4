using ServiTec.Bibl.Reportes.Producto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiTec.Wind
{
    public partial class Form1 : Form
    {
        VentasPorProductoBl ventasPorProductoBl;
        public Form1()
        {
            InitializeComponent();
            this.ventasPorProductoBl = new VentasPorProductoBl();
            RefrescarDatos();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RefrescarDatos();
        }

        private void RefrescarDatos() 
        {
            var lista = this.ventasPorProductoBl.ObtenerVentasPorProducto();
            listaVentasPorProductosBindingSource.DataSource = lista;
            listaVentasPorProductosBindingSource.ResetBindings(false);
        }
    }
}
