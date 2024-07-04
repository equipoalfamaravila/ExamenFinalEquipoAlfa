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
    public partial class frmVendedor : Form
    {
        public frmVendedor()
        {
            InitializeComponent();
        }
        VentasDataContext ventas = new VentasDataContext();
        private void Listar()
        {

            var consulta = from V in ventas.Vendedor
                           select V;
            dgvVendedor.DataSource = consulta;
        }
        private void frmVendedor_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void btnAgregarVendedor_Click(object sender, EventArgs e)
        {
            Vendedor vendedor = new Vendedor();
            vendedor.CodVendedor = txtCodVendedor.Text;
            vendedor.Apellidos = txtApellidosVendedor.Text;
            vendedor.Nombres = txtNombresVendedor.Text;
            ventas.Vendedor.InsertOnSubmit(vendedor);

            try
            {
                ventas.SubmitChanges();//Confirmar la transaccion
                txtCodVendedor.Clear(); txtNombresVendedor.Clear(); txtApellidosVendedor.Clear();
                txtCodVendedor.Focus();
                Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnEliminarVendedor_Click(object sender, EventArgs e)
        {
            var CodVendedorEliminar = (from V in ventas.Vendedor
                                      where V.CodVendedor.Contains(txtCodVendedor.Text)
                                      select V).First();
            ventas.Vendedor.DeleteOnSubmit(CodVendedorEliminar);

            try
            {
                ventas.SubmitChanges();//Confirmar la transaccion
                txtCodVendedor.Clear(); txtNombresVendedor.Clear(); txtApellidosVendedor.Clear();
                txtCodVendedor.Focus();
                Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnConsultarVendedor_Click(object sender, EventArgs e)
        {
            var consulta = from V in ventas.Vendedor
                           where V.CodVendedor.Contains(txtCodVendedor.Text)
                           select V;
            dgvVendedor.DataSource = consulta.ToList();
        }

        private void BtnAtrasVendedor_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
