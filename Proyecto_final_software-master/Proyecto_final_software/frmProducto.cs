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
    public partial class frmProducto : Form
    {
        public frmProducto()
        {
            InitializeComponent();
        }
        VentasDataContext ventas = new VentasDataContext();
        private void Listar()
        {

            var consulta = from P in ventas.Producto
                           select new
                           {
                               P.CodProduto,
                               P.Nombre,
                               P.UnidadDeMedida,
                               P.Precio,
                               P.Stock,
                               P.CodCategoria
                           };
            dgvProducto.DataSource = consulta;
        }
        private void NroBoleta_Click(object sender, EventArgs e)
        {

        }

        private void dgvProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmProducto_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();
            producto.CodProduto = txtCodProducto.Text;
            producto.Nombre = txtNombreProducto.Text;
            producto.UnidadDeMedida = txtUnidadProducto.Text;
            producto.Precio = Convert.ToDecimal(txtPrecioProducto.Text); 
            producto.Stock = Convert.ToInt32(txtStockProducto.Text);
            producto.CodCategoria = txtCodCategoriaProducto.Text;
            ventas.Producto.InsertOnSubmit(producto);

            try
            {
                ventas.SubmitChanges();//Confirmar la transaccion
                txtCodProducto.Clear(); 
                txtNombreProducto.Clear();
                txtUnidadProducto.Clear();
                txtPrecioProducto.Clear();
                txtStockProducto.Clear();
                txtCodCategoriaProducto.Clear();
                txtCodProducto.Focus();
                Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnConsultarProducto_Click(object sender, EventArgs e)
        {
            var consulta = from P in ventas.Producto
                           where P.CodProduto.Contains(txtCodProducto.Text)
                           select P;
            dgvProducto.DataSource = consulta.ToList();
        }

        private void BtnAtrasProducto_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
