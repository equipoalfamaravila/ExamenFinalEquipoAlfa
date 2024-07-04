namespace Proyecto_final_software
{
    partial class frmProducto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NroBoleta = new System.Windows.Forms.Label();
            this.txtCodProducto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUnidadProducto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrecioProducto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStockProducto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCodCategoriaProducto = new System.Windows.Forms.TextBox();
            this.dgvProducto = new System.Windows.Forms.DataGridView();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.btnConsultarProducto = new System.Windows.Forms.Button();
            this.btnAtrasProducto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // NroBoleta
            // 
            this.NroBoleta.AutoSize = true;
            this.NroBoleta.Location = new System.Drawing.Point(22, 52);
            this.NroBoleta.Name = "NroBoleta";
            this.NroBoleta.Size = new System.Drawing.Size(102, 13);
            this.NroBoleta.TabIndex = 5;
            this.NroBoleta.Text = "Codigo del producto";
            this.NroBoleta.Click += new System.EventHandler(this.NroBoleta_Click);
            // 
            // txtCodProducto
            // 
            this.txtCodProducto.Location = new System.Drawing.Point(133, 49);
            this.txtCodProducto.Name = "txtCodProducto";
            this.txtCodProducto.Size = new System.Drawing.Size(153, 20);
            this.txtCodProducto.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre";
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(133, 99);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(153, 20);
            this.txtNombreProducto.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Unidad de medida";
            // 
            // txtUnidadProducto
            // 
            this.txtUnidadProducto.Location = new System.Drawing.Point(133, 155);
            this.txtUnidadProducto.Name = "txtUnidadProducto";
            this.txtUnidadProducto.Size = new System.Drawing.Size(153, 20);
            this.txtUnidadProducto.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(389, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Precio";
            // 
            // txtPrecioProducto
            // 
            this.txtPrecioProducto.Location = new System.Drawing.Point(483, 49);
            this.txtPrecioProducto.Name = "txtPrecioProducto";
            this.txtPrecioProducto.Size = new System.Drawing.Size(153, 20);
            this.txtPrecioProducto.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(389, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Stock";
            // 
            // txtStockProducto
            // 
            this.txtStockProducto.Location = new System.Drawing.Point(483, 92);
            this.txtStockProducto.Name = "txtStockProducto";
            this.txtStockProducto.Size = new System.Drawing.Size(153, 20);
            this.txtStockProducto.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(363, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Codigo de la Categoria";
            // 
            // txtCodCategoriaProducto
            // 
            this.txtCodCategoriaProducto.Location = new System.Drawing.Point(483, 155);
            this.txtCodCategoriaProducto.Name = "txtCodCategoriaProducto";
            this.txtCodCategoriaProducto.Size = new System.Drawing.Size(153, 20);
            this.txtCodCategoriaProducto.TabIndex = 14;
            // 
            // dgvProducto
            // 
            this.dgvProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducto.Location = new System.Drawing.Point(12, 264);
            this.dgvProducto.Name = "dgvProducto";
            this.dgvProducto.Size = new System.Drawing.Size(776, 174);
            this.dgvProducto.TabIndex = 16;
            this.dgvProducto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducto_CellContentClick);
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Location = new System.Drawing.Point(42, 221);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(82, 23);
            this.btnAgregarProducto.TabIndex = 17;
            this.btnAgregarProducto.Text = "Agregar";
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // btnConsultarProducto
            // 
            this.btnConsultarProducto.Location = new System.Drawing.Point(366, 221);
            this.btnConsultarProducto.Name = "btnConsultarProducto";
            this.btnConsultarProducto.Size = new System.Drawing.Size(86, 23);
            this.btnConsultarProducto.TabIndex = 18;
            this.btnConsultarProducto.Text = "Conusltar";
            this.btnConsultarProducto.UseVisualStyleBackColor = true;
            this.btnConsultarProducto.Click += new System.EventHandler(this.btnConsultarProducto_Click);
            // 
            // btnAtrasProducto
            // 
            this.btnAtrasProducto.Location = new System.Drawing.Point(669, 221);
            this.btnAtrasProducto.Name = "btnAtrasProducto";
            this.btnAtrasProducto.Size = new System.Drawing.Size(86, 23);
            this.btnAtrasProducto.TabIndex = 19;
            this.btnAtrasProducto.Text = "Atras";
            this.btnAtrasProducto.UseVisualStyleBackColor = true;
            this.btnAtrasProducto.Click += new System.EventHandler(this.BtnAtrasProducto_Click);
            // 
            // frmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAtrasProducto);
            this.Controls.Add(this.btnConsultarProducto);
            this.Controls.Add(this.btnAgregarProducto);
            this.Controls.Add(this.dgvProducto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCodCategoriaProducto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtStockProducto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPrecioProducto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUnidadProducto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombreProducto);
            this.Controls.Add(this.NroBoleta);
            this.Controls.Add(this.txtCodProducto);
            this.Name = "frmProducto";
            this.Text = "frmProducto";
            this.Load += new System.EventHandler(this.frmProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NroBoleta;
        private System.Windows.Forms.TextBox txtCodProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUnidadProducto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrecioProducto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStockProducto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCodCategoriaProducto;
        private System.Windows.Forms.DataGridView dgvProducto;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.Button btnConsultarProducto;
        private System.Windows.Forms.Button btnAtrasProducto;
    }
}