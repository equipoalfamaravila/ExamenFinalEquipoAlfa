namespace Proyecto_final_software
{
    partial class frmMenu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnBoleta = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.btnVendedor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBoleta
            // 
            this.btnBoleta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnBoleta.Location = new System.Drawing.Point(28, 38);
            this.btnBoleta.Name = "btnBoleta";
            this.btnBoleta.Size = new System.Drawing.Size(273, 162);
            this.btnBoleta.TabIndex = 0;
            this.btnBoleta.Text = "Boletas";
            this.btnBoleta.UseVisualStyleBackColor = false;
            this.btnBoleta.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnProductos.Location = new System.Drawing.Point(307, 38);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(281, 241);
            this.btnProductos.TabIndex = 1;
            this.btnProductos.Text = "Productos";
            this.btnProductos.UseVisualStyleBackColor = false;
            this.btnProductos.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCliente.Location = new System.Drawing.Point(38, 206);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(217, 216);
            this.btnCliente.TabIndex = 2;
            this.btnCliente.Text = "Clientes";
            this.btnCliente.UseVisualStyleBackColor = false;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnVendedor
            // 
            this.btnVendedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnVendedor.Location = new System.Drawing.Point(261, 285);
            this.btnVendedor.Name = "btnVendedor";
            this.btnVendedor.Size = new System.Drawing.Size(327, 137);
            this.btnVendedor.TabIndex = 3;
            this.btnVendedor.Text = "Vendedor";
            this.btnVendedor.UseVisualStyleBackColor = false;
            this.btnVendedor.Click += new System.EventHandler(this.button4_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 450);
            this.Controls.Add(this.btnVendedor);
            this.Controls.Add(this.btnCliente);
            this.Controls.Add(this.btnProductos);
            this.Controls.Add(this.btnBoleta);
            this.Name = "frmMenu";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBoleta;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Button btnVendedor;
    }
}

