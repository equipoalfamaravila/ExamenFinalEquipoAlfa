namespace Proyecto_final_software
{
    partial class frmBoleta
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
            this.txtNroBoleta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFechaBoleta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodVendedorBoleta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAnuladoBoleta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCodClienteBoleta = new System.Windows.Forms.TextBox();
            this.dgvBoleta = new System.Windows.Forms.DataGridView();
            this.btnAgregarBoleta = new System.Windows.Forms.Button();
            this.btnConsultarBoleta = new System.Windows.Forms.Button();
            this.btnAtrasBoleta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBoleta)).BeginInit();
            this.SuspendLayout();
            // 
            // NroBoleta
            // 
            this.NroBoleta.AutoSize = true;
            this.NroBoleta.Location = new System.Drawing.Point(51, 56);
            this.NroBoleta.Name = "NroBoleta";
            this.NroBoleta.Size = new System.Drawing.Size(56, 13);
            this.NroBoleta.TabIndex = 3;
            this.NroBoleta.Text = "Nro boleta";
            this.NroBoleta.Click += new System.EventHandler(this.Codigo_Click);
            // 
            // txtNroBoleta
            // 
            this.txtNroBoleta.Location = new System.Drawing.Point(145, 56);
            this.txtNroBoleta.Name = "txtNroBoleta";
            this.txtNroBoleta.Size = new System.Drawing.Size(153, 20);
            this.txtNroBoleta.TabIndex = 2;
            this.txtNroBoleta.TextChanged += new System.EventHandler(this.txtBoleta_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Fecha";
            // 
            // txtFechaBoleta
            // 
            this.txtFechaBoleta.Location = new System.Drawing.Point(145, 112);
            this.txtFechaBoleta.Name = "txtFechaBoleta";
            this.txtFechaBoleta.Size = new System.Drawing.Size(153, 20);
            this.txtFechaBoleta.TabIndex = 4;
            this.txtFechaBoleta.TextChanged += new System.EventHandler(this.txtFecha_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(378, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Codigo del vendedor";
            // 
            // txtCodVendedorBoleta
            // 
            this.txtCodVendedorBoleta.Location = new System.Drawing.Point(501, 53);
            this.txtCodVendedorBoleta.Name = "txtCodVendedorBoleta";
            this.txtCodVendedorBoleta.Size = new System.Drawing.Size(153, 20);
            this.txtCodVendedorBoleta.TabIndex = 6;
            this.txtCodVendedorBoleta.TextChanged += new System.EventHandler(this.txtCodVendedor_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(396, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Anulado";
            // 
            // txtAnuladoBoleta
            // 
            this.txtAnuladoBoleta.Location = new System.Drawing.Point(490, 112);
            this.txtAnuladoBoleta.Name = "txtAnuladoBoleta";
            this.txtAnuladoBoleta.Size = new System.Drawing.Size(153, 20);
            this.txtAnuladoBoleta.TabIndex = 8;
            this.txtAnuladoBoleta.TextChanged += new System.EventHandler(this.txtAnulado_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Codigo del Cliente";
            // 
            // txtCodClienteBoleta
            // 
            this.txtCodClienteBoleta.Location = new System.Drawing.Point(145, 158);
            this.txtCodClienteBoleta.Name = "txtCodClienteBoleta";
            this.txtCodClienteBoleta.Size = new System.Drawing.Size(153, 20);
            this.txtCodClienteBoleta.TabIndex = 10;
            this.txtCodClienteBoleta.TextChanged += new System.EventHandler(this.txtCodCliente_TextChanged);
            // 
            // dgvBoleta
            // 
            this.dgvBoleta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBoleta.Location = new System.Drawing.Point(58, 243);
            this.dgvBoleta.Name = "dgvBoleta";
            this.dgvBoleta.Size = new System.Drawing.Size(701, 165);
            this.dgvBoleta.TabIndex = 12;
            this.dgvBoleta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBoleta_CellContentClick);
            // 
            // btnAgregarBoleta
            // 
            this.btnAgregarBoleta.Location = new System.Drawing.Point(145, 195);
            this.btnAgregarBoleta.Name = "btnAgregarBoleta";
            this.btnAgregarBoleta.Size = new System.Drawing.Size(131, 42);
            this.btnAgregarBoleta.TabIndex = 13;
            this.btnAgregarBoleta.Text = "Agregar";
            this.btnAgregarBoleta.UseVisualStyleBackColor = true;
            this.btnAgregarBoleta.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnConsultarBoleta
            // 
            this.btnConsultarBoleta.Location = new System.Drawing.Point(364, 195);
            this.btnConsultarBoleta.Name = "btnConsultarBoleta";
            this.btnConsultarBoleta.Size = new System.Drawing.Size(119, 42);
            this.btnConsultarBoleta.TabIndex = 14;
            this.btnConsultarBoleta.Text = "Consultar";
            this.btnConsultarBoleta.UseVisualStyleBackColor = true;
            this.btnConsultarBoleta.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAtrasBoleta
            // 
            this.btnAtrasBoleta.Location = new System.Drawing.Point(584, 195);
            this.btnAtrasBoleta.Name = "btnAtrasBoleta";
            this.btnAtrasBoleta.Size = new System.Drawing.Size(119, 42);
            this.btnAtrasBoleta.TabIndex = 15;
            this.btnAtrasBoleta.Text = "Atras";
            this.btnAtrasBoleta.UseVisualStyleBackColor = true;
            this.btnAtrasBoleta.Click += new System.EventHandler(this.BtnAtrasBoleta_Click);
            // 
            // frmBoleta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAtrasBoleta);
            this.Controls.Add(this.btnConsultarBoleta);
            this.Controls.Add(this.btnAgregarBoleta);
            this.Controls.Add(this.dgvBoleta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCodClienteBoleta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAnuladoBoleta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCodVendedorBoleta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFechaBoleta);
            this.Controls.Add(this.NroBoleta);
            this.Controls.Add(this.txtNroBoleta);
            this.Name = "frmBoleta";
            this.Text = "BOLETAS";
            this.Load += new System.EventHandler(this.frmBoleta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBoleta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NroBoleta;
        private System.Windows.Forms.TextBox txtNroBoleta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFechaBoleta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodVendedorBoleta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAnuladoBoleta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCodClienteBoleta;
        private System.Windows.Forms.DataGridView dgvBoleta;
        private System.Windows.Forms.Button btnAgregarBoleta;
        private System.Windows.Forms.Button btnConsultarBoleta;
        private System.Windows.Forms.Button btnAtrasBoleta;
    }
}