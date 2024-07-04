namespace Proyecto_final_software
{
    partial class frmVenta
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBoxVendedor = new System.Windows.Forms.ComboBox();
            this.comboBoxProducto = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNroBoletaVentas = new System.Windows.Forms.TextBox();
            this.textFechaVenta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnAtrasVenta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo de Cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Codigo de Vendedor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Codigo de Producto";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(156, 140);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // comboBoxVendedor
            // 
            this.comboBoxVendedor.FormattingEnabled = true;
            this.comboBoxVendedor.Location = new System.Drawing.Point(156, 186);
            this.comboBoxVendedor.Name = "comboBoxVendedor";
            this.comboBoxVendedor.Size = new System.Drawing.Size(121, 21);
            this.comboBoxVendedor.TabIndex = 5;
            this.comboBoxVendedor.SelectedIndexChanged += new System.EventHandler(this.ComboBoxVendedor_SelectedIndexChanged);
            // 
            // comboBoxProducto
            // 
            this.comboBoxProducto.FormattingEnabled = true;
            this.comboBoxProducto.Location = new System.Drawing.Point(156, 226);
            this.comboBoxProducto.Name = "comboBoxProducto";
            this.comboBoxProducto.Size = new System.Drawing.Size(121, 21);
            this.comboBoxProducto.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nro de Boleta:";
            // 
            // txtNroBoletaVentas
            // 
            this.txtNroBoletaVentas.Location = new System.Drawing.Point(156, 48);
            this.txtNroBoletaVentas.Name = "txtNroBoletaVentas";
            this.txtNroBoletaVentas.Size = new System.Drawing.Size(121, 20);
            this.txtNroBoletaVentas.TabIndex = 8;
            // 
            // textFechaVenta
            // 
            this.textFechaVenta.Location = new System.Drawing.Point(156, 90);
            this.textFechaVenta.Name = "textFechaVenta";
            this.textFechaVenta.Size = new System.Drawing.Size(121, 20);
            this.textFechaVenta.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Fecha:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(53, 308);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 11;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // btnAtrasVenta
            // 
            this.btnAtrasVenta.Location = new System.Drawing.Point(156, 307);
            this.btnAtrasVenta.Name = "btnAtrasVenta";
            this.btnAtrasVenta.Size = new System.Drawing.Size(75, 23);
            this.btnAtrasVenta.TabIndex = 12;
            this.btnAtrasVenta.Text = "Atras";
            this.btnAtrasVenta.UseVisualStyleBackColor = true;
            this.btnAtrasVenta.Click += new System.EventHandler(this.BtnAtrasVenta_Click);
            // 
            // frmVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 395);
            this.Controls.Add(this.btnAtrasVenta);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.textFechaVenta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNroBoletaVentas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxProducto);
            this.Controls.Add(this.comboBoxVendedor);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmVenta";
            this.Text = "VENTA";
            this.Load += new System.EventHandler(this.FrmVenta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBoxVendedor;
        private System.Windows.Forms.ComboBox comboBoxProducto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNroBoletaVentas;
        private System.Windows.Forms.TextBox textFechaVenta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnAtrasVenta;
    }
}