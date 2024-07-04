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
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmBoleta frmBoleta = new frmBoleta();
            frmBoleta.StartPosition = FormStartPosition.CenterScreen;
            frmBoleta.Show();
            this.Hide();
            frmBoleta.FormClosed += (s, args) => this.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmVendedor frmVendedor = new frmVendedor();
            frmVendedor.StartPosition = FormStartPosition.CenterScreen;
            frmVendedor.Show();
            this.Hide();
            frmVendedor.FormClosed += (s, args) => this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmProducto frmProducto = new frmProducto();
            frmProducto.StartPosition = FormStartPosition.CenterScreen;
            frmProducto.Show();
            this.Hide();
            frmProducto.FormClosed += (s, args) => this.Show();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            FrmCliente frmCliente = new FrmCliente();
            frmCliente.StartPosition = FormStartPosition.CenterScreen;
            frmCliente.Show();
            this.Hide();
            frmCliente.FormClosed += (s, args) => this.Show();


        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            
        }
    }
}
