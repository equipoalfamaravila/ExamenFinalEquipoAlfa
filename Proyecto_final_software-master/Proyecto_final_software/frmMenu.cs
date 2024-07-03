using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_final_software
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmBoleta frmBoleta = new frmBoleta();
            frmBoleta.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmVendedor frmVendedor = new frmVendedor();
            frmVendedor.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmProducto frmProducto = new frmProducto();
            frmProducto.Show();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            FrmCliente frmCliente = new FrmCliente();
            frmCliente.Show();
        }
    }
}
