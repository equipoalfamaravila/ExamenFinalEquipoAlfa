using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Proyecto_final_software
{
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
        }
        VentasDataContext ventas = new VentasDataContext();
        private void Listar()
        {

            var consulta = from C in ventas.Cliente
                           select C;
            dgvCliente.DataSource = consulta;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.CodCliente = txtCodCliente.Text;
            cliente.Apellidos = txtApellidosCliente.Text;
            cliente.Nombres = txtNombreCliente.Text;
            cliente.Direccion = txtDireccionCliente.Text;
            ventas.Cliente.InsertOnSubmit(cliente);
            try
            {
                ventas.SubmitChanges();//Confirmar la transaccion
                txtCodCliente.Clear(); txtNombreCliente.Clear(); txtApellidosCliente.Clear();txtDireccionCliente.Clear();
                txtCodCliente.Focus();
                Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            var CodClienteEliminar = (from C in ventas.Cliente
                                      where C.CodCliente.Contains(txtCodCliente.Text)
                                      select C).First();
            ventas.Cliente.DeleteOnSubmit(CodClienteEliminar);

            try
            {
                ventas.SubmitChanges();//Confirmar la transaccion
                txtCodCliente.Clear(); txtNombreCliente.Clear(); txtApellidosCliente.Clear(); txtDireccionCliente.Clear();
                txtCodCliente.Focus();
                Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            var consulta = from C in ventas.Cliente
                           where C.CodCliente.Contains(txtCodCliente.Text)
                           select C;
            dgvCliente.DataSource = consulta.ToList();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnAtrasCliente_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
