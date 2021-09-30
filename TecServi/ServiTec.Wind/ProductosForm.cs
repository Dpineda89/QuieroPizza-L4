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
    public partial class ProductosForm : Form
    {
        ProductoBibl productoBibl;
        public ProductosForm()
        {
            this.productoBibl = new ProductoBibl();
            InitializeComponent();
        }

        private void ProductosForm_Load(object sender, EventArgs e)
        {
            var productosBl = new ServiTec.Bibl.ProductoBibl();
            var listadeProductos = productosBl.ObtenerProductos();
            this.listadeProductosDataGridView.DataSource = listadeProductos;
        }
    }
}
