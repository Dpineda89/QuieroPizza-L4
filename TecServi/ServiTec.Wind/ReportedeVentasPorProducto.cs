using ServiTec.Bibl;
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
    public partial class ReportedeVentasPorProducto : Form
    {
        ReporteVentasPorProductoBibl reporteVentasPorProductoBibl;
        public ReportedeVentasPorProducto()
        {
            InitializeComponent();
            reporteVentasPorProductoBibl = new ReporteVentasPorProductoBibl();

            RefrescarDatos();
        }

        private void listadeVentasPorProductoDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RefrescarDatos();
        }

        private void RefrescarDatos ()
        {
            var listadeVentasPorProducto = reporteVentasPorProductoBibl.ObtenerVetasPorProducto();
            listadeVentasPorProductoBindingSource.DataSource = listadeVentasPorProducto;
            listadeVentasPorProductoBindingSource.ResetBindings(false);
        }
    }
}
