using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_final_software
{
    public partial class frmBoleta : Form
    {
        public frmBoleta()
        {
            InitializeComponent();
        }
        VentasDataContext ventas = new VentasDataContext();
        private void Listar()
        {

            var consulta = from B in ventas.Boleta
                           select new
                           {
                               B.NroBoleta,
                               B.Fecha,
                               B.CodCliente,
                               B.CodVendedor,
                               B.Anulado
                           };
            dgvBoleta.DataSource = consulta;
        }
        private void Codigo_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var consulta = from B in ventas.Boleta
                           where Convert.ToString(B.NroBoleta).Contains(txtNroBoleta.Text) 
                           select B;
            dgvBoleta.DataSource = consulta.ToList();
        }

        private void txtBoleta_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFecha_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCodCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCodVendedor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAnulado_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            /*Boleta boleta = new Boleta();
            boleta.NroBoleta = Convert.ToInt32(txtNroBoleta.Text);
            boleta.Fecha = Convert.ToDateTime(txtFechaBoleta.Text);
            boleta.Anulado = Convert.ToBoolean(txtAnuladoBoleta.Text);
            boleta.CodCliente = txtCodClienteBoleta.Text;
            boleta.CodVendedor = txtCodVendedorBoleta.Text;
            ventas.Boleta.InsertOnSubmit(boleta); 
            

            try
            {
                ventas.SubmitChanges();//Confirmar la transaccion
                txtNroBoleta.Clear();
                txtFechaBoleta.Clear();
                txtCodClienteBoleta.Clear();
                txtAnuladoBoleta.Clear();
                txtFechaBoleta.Clear();

                Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }*/
            frmVenta frmVenta = new frmVenta();
            frmVenta.StartPosition = FormStartPosition.CenterScreen;
            frmVenta.Show();
            this.Hide();
            frmVenta.FormClosed += (s, args) => this.Show();
            frmVenta.FormClosed += (s, args) => this.Listar();

        }

        private void dgvBoleta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmBoleta_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void BtnAtrasBoleta_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}
