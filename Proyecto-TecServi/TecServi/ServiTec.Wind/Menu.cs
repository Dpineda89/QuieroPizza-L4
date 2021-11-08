using ServiTec.Wind;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiTecWin
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();

        }
        void btnUpdate_Click(object sender, EventArgs e) 
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {
            /*var form = new Login();
            form.MdiParent = this;
            form.FormClosed += Form_FormClosed;
            form.Show();*/
        }

        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            //toolStripStatusLabel1.Text += DeliverySystem.Libreria.Utilidades.GeneralInfo.Usuario;
        }

        void ob_ButtonClicked(object sender, EventArgs e)
        {
        }

        private void mostrarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new ProductosForm();
            form.MdiParent = this;
            form.Show();
        }

        private void agregarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {/*
            var form = new CrearProducto();
            form.MdiParent = this;
            form.Show();*/
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
