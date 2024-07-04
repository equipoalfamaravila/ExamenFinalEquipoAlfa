namespace Proyecto_final_software
{
    partial class frmVendedor
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
            this.txtCodVendedor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombresVendedor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtApellidosVendedor = new System.Windows.Forms.TextBox();
            this.btnAgregarVendedor = new System.Windows.Forms.Button();
            this.btnEliminarVendedor = new System.Windows.Forms.Button();
            this.btnConsultarVendedor = new System.Windows.Forms.Button();
            this.dgvVendedor = new System.Windows.Forms.DataGridView();
            this.btnAtrasVendedor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendedor)).BeginInit();
            this.SuspendLayout();
            // 
            // NroBoleta
            // 
            this.NroBoleta.AutoSize = true;
            this.NroBoleta.Location = new System.Drawing.Point(60, 50);
            this.NroBoleta.Name = "NroBoleta";
            this.NroBoleta.Size = new System.Drawing.Size(105, 13);
            this.NroBoleta.TabIndex = 7;
            this.NroBoleta.Text = "Codigo del vendedor";
            // 
            // txtCodVendedor
            // 
            this.txtCodVendedor.Location = new System.Drawing.Point(171, 47);
            this.txtCodVendedor.Name = "txtCodVendedor";
            this.txtCodVendedor.Size = new System.Drawing.Size(153, 20);
            this.txtCodVendedor.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nombres";
            // 
            // txtNombresVendedor
            // 
            this.txtNombresVendedor.Location = new System.Drawing.Point(171, 113);
            this.txtNombresVendedor.Name = "txtNombresVendedor";
            this.txtNombresVendedor.Size = new System.Drawing.Size(153, 20);
            this.txtNombresVendedor.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(410, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Apellidos";
            // 
            // txtApellidosVendedor
            // 
            this.txtApellidosVendedor.Location = new System.Drawing.Point(521, 50);
            this.txtApellidosVendedor.Name = "txtApellidosVendedor";
            this.txtApellidosVendedor.Size = new System.Drawing.Size(153, 20);
            this.txtApellidosVendedor.TabIndex = 10;
            // 
            // btnAgregarVendedor
            // 
            this.btnAgregarVendedor.Location = new System.Drawing.Point(97, 183);
            this.btnAgregarVendedor.Name = "btnAgregarVendedor";
            this.btnAgregarVendedor.Size = new System.Drawing.Size(101, 36);
            this.btnAgregarVendedor.TabIndex = 12;
            this.btnAgregarVendedor.Text = "Agregar";
            this.btnAgregarVendedor.UseVisualStyleBackColor = true;
            this.btnAgregarVendedor.Click += new System.EventHandler(this.btnAgregarVendedor_Click);
            // 
            // btnEliminarVendedor
            // 
            this.btnEliminarVendedor.Location = new System.Drawing.Point(260, 183);
            this.btnEliminarVendedor.Name = "btnEliminarVendedor";
            this.btnEliminarVendedor.Size = new System.Drawing.Size(103, 36);
            this.btnEliminarVendedor.TabIndex = 13;
            this.btnEliminarVendedor.Text = "Eliminar";
            this.btnEliminarVendedor.UseVisualStyleBackColor = true;
            this.btnEliminarVendedor.Click += new System.EventHandler(this.btnEliminarVendedor_Click);
            // 
            // btnConsultarVendedor
            // 
            this.btnConsultarVendedor.Location = new System.Drawing.Point(432, 183);
            this.btnConsultarVendedor.Name = "btnConsultarVendedor";
            this.btnConsultarVendedor.Size = new System.Drawing.Size(101, 36);
            this.btnConsultarVendedor.TabIndex = 14;
            this.btnConsultarVendedor.Text = "Consultar";
            this.btnConsultarVendedor.UseVisualStyleBackColor = true;
            this.btnConsultarVendedor.Click += new System.EventHandler(this.btnConsultarVendedor_Click);
            // 
            // dgvVendedor
            // 
            this.dgvVendedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVendedor.Location = new System.Drawing.Point(32, 244);
            this.dgvVendedor.Name = "dgvVendedor";
            this.dgvVendedor.Size = new System.Drawing.Size(712, 174);
            this.dgvVendedor.TabIndex = 15;
            // 
            // btnAtrasVendedor
            // 
            this.btnAtrasVendedor.Location = new System.Drawing.Point(600, 183);
            this.btnAtrasVendedor.Name = "btnAtrasVendedor";
            this.btnAtrasVendedor.Size = new System.Drawing.Size(101, 36);
            this.btnAtrasVendedor.TabIndex = 16;
            this.btnAtrasVendedor.Text = "Atras";
            this.btnAtrasVendedor.UseVisualStyleBackColor = true;
            this.btnAtrasVendedor.Click += new System.EventHandler(this.BtnAtrasVendedor_Click);
            // 
            // frmVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAtrasVendedor);
            this.Controls.Add(this.dgvVendedor);
            this.Controls.Add(this.btnConsultarVendedor);
            this.Controls.Add(this.btnEliminarVendedor);
            this.Controls.Add(this.btnAgregarVendedor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtApellidosVendedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombresVendedor);
            this.Controls.Add(this.NroBoleta);
            this.Controls.Add(this.txtCodVendedor);
            this.Name = "frmVendedor";
            this.Text = "frmVendedor";
            this.Load += new System.EventHandler(this.frmVendedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NroBoleta;
        private System.Windows.Forms.TextBox txtCodVendedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombresVendedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtApellidosVendedor;
        private System.Windows.Forms.Button btnAgregarVendedor;
        private System.Windows.Forms.Button btnEliminarVendedor;
        private System.Windows.Forms.Button btnConsultarVendedor;
        private System.Windows.Forms.DataGridView dgvVendedor;
        private System.Windows.Forms.Button btnAtrasVendedor;
    }
}