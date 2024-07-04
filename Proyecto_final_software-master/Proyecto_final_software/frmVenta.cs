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
    public partial class frmVenta : Form
    {
        public frmVenta()
        {
            InitializeComponent();
            LlenarComboBox();
            LlenarComboBoxVendedor();
            LlenarComboBoxProducto();
        }
        VentasDataContext ventas = new VentasDataContext();
        private void LlenarComboBox()
        {
            var clientes = from V in ventas.Cliente
                           select new
                           {
                               V.CodCliente
                           };
                

            comboBox1.DataSource = clientes.ToList();
            comboBox1.DisplayMember = "CodCliente"; // Mostrar el código de cliente en el ComboBox
            comboBox1.ValueMember = "CodCliente";

        }
        private void LlenarComboBoxVendedor()
        {
            var vendedor = from V in ventas.Vendedor
                           select new
                           {
                               V.CodVendedor
                           };


            comboBoxVendedor.DataSource = vendedor.ToList();
            comboBoxVendedor.DisplayMember = "CodVendedor"; // Mostrar el código de cliente en el ComboBox
            comboBoxVendedor.ValueMember = "CodVendedor";

        }
        private void LlenarComboBoxProducto()
        {
            var producto = from V in ventas.Detalle
                           select new
                           {
                               V.CodProducto
                           };


            comboBoxProducto.DataSource = producto.ToList();
            comboBoxProducto.DisplayMember = "CodProducto"; // Mostrar el código de cliente en el ComboBox
            comboBoxProducto.ValueMember = "CodProducto";

        }
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void ComboBoxVendedor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmVenta_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            Boleta boleta = new Boleta();
            boleta.NroBoleta = Convert.ToInt32(txtNroBoletaVentas.Text);
            boleta.Fecha = Convert.ToDateTime(textFechaVenta.Text);
            boleta.CodCliente = comboBox1.Text;
            boleta.CodVendedor = comboBoxVendedor.Text;
            boleta.Anulado = Convert.ToBoolean("False");
            ventas.Boleta.InsertOnSubmit(boleta);
            frmBoleta frmBoleta = new frmBoleta();
            try
            {
                ventas.SubmitChanges();//Confirmar la transaccion
                txtNroBoletaVentas.Clear();
                textFechaVenta.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        /*private void mostrardatos()
        {
            var consulta = from C in ventas.Cliente
                           where C.CodCliente.Contains(comboBox1.Text)
                           select new
                           {
                               dato = C.Nombres + " " + C.Apellidos
                           };
            
        }*/
        private void TxtInfoCliente_TextChanged(object sender, EventArgs e)
        {
            
          
        }

        private void BtnAtrasVenta_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
