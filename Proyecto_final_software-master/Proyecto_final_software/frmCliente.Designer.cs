namespace Proyecto_final_software
{
    partial class FrmCliente
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
            this.txtCodCliente = new System.Windows.Forms.TextBox();
            this.Codigo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtApellidosCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDireccionCliente = new System.Windows.Forms.TextBox();
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.btnAgregarCliente = new System.Windows.Forms.Button();
            this.btnEliminarCliente = new System.Windows.Forms.Button();
            this.btnConsultarCliente = new System.Windows.Forms.Button();
            this.btnAtrasCliente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCodCliente
            // 
            this.txtCodCliente.Location = new System.Drawing.Point(127, 55);
            this.txtCodCliente.Name = "txtCodCliente";
            this.txtCodCliente.Size = new System.Drawing.Size(153, 20);
            this.txtCodCliente.TabIndex = 0;
            this.txtCodCliente.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Codigo
            // 
            this.Codigo.AutoSize = true;
            this.Codigo.Location = new System.Drawing.Point(33, 55);
            this.Codigo.Name = "Codigo";
            this.Codigo.Size = new System.Drawing.Size(40, 13);
            this.Codigo.TabIndex = 1;
            this.Codigo.Text = "Codigo";
            this.Codigo.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombres";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(127, 112);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(153, 20);
            this.txtNombreCliente.TabIndex = 2;
            this.txtNombreCliente.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(389, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Apellidos";
            // 
            // txtApellidosCliente
            // 
            this.txtApellidosCliente.Location = new System.Drawing.Point(483, 109);
            this.txtApellidosCliente.Name = "txtApellidosCliente";
            this.txtApellidosCliente.Size = new System.Drawing.Size(153, 20);
            this.txtApellidosCliente.TabIndex = 4;
            this.txtApellidosCliente.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(389, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Direccion";
            // 
            // txtDireccionCliente
            // 
            this.txtDireccionCliente.Location = new System.Drawing.Point(483, 55);
            this.txtDireccionCliente.Name = "txtDireccionCliente";
            this.txtDireccionCliente.Size = new System.Drawing.Size(153, 20);
            this.txtDireccionCliente.TabIndex = 6;
            this.txtDireccionCliente.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // dgvCliente
            // 
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.Location = new System.Drawing.Point(36, 241);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.Size = new System.Drawing.Size(810, 241);
            this.dgvCliente.TabIndex = 8;
            this.dgvCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCliente_CellContentClick);
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.Location = new System.Drawing.Point(66, 186);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Size = new System.Drawing.Size(154, 35);
            this.btnAgregarCliente.TabIndex = 9;
            this.btnAgregarCliente.Text = "Agregar";
            this.btnAgregarCliente.UseVisualStyleBackColor = true;
            this.btnAgregarCliente.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // btnEliminarCliente
            // 
            this.btnEliminarCliente.Location = new System.Drawing.Point(285, 186);
            this.btnEliminarCliente.Name = "btnEliminarCliente";
            this.btnEliminarCliente.Size = new System.Drawing.Size(153, 35);
            this.btnEliminarCliente.TabIndex = 10;
            this.btnEliminarCliente.Text = "Eliminar";
            this.btnEliminarCliente.UseVisualStyleBackColor = true;
            this.btnEliminarCliente.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // btnConsultarCliente
            // 
            this.btnConsultarCliente.Location = new System.Drawing.Point(494, 186);
            this.btnConsultarCliente.Name = "btnConsultarCliente";
            this.btnConsultarCliente.Size = new System.Drawing.Size(120, 35);
            this.btnConsultarCliente.TabIndex = 11;
            this.btnConsultarCliente.Text = "Consultar";
            this.btnConsultarCliente.UseVisualStyleBackColor = true;
            this.btnConsultarCliente.Click += new System.EventHandler(this.BtnConsultar_Click);
            // 
            // btnAtrasCliente
            // 
            this.btnAtrasCliente.Location = new System.Drawing.Point(672, 186);
            this.btnAtrasCliente.Name = "btnAtrasCliente";
            this.btnAtrasCliente.Size = new System.Drawing.Size(120, 35);
            this.btnAtrasCliente.TabIndex = 12;
            this.btnAtrasCliente.Text = "Atras";
            this.btnAtrasCliente.UseVisualStyleBackColor = true;
            this.btnAtrasCliente.Click += new System.EventHandler(this.BtnAtrasCliente_Click);
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 494);
            this.Controls.Add(this.btnAtrasCliente);
            this.Controls.Add(this.btnConsultarCliente);
            this.Controls.Add(this.btnEliminarCliente);
            this.Controls.Add(this.btnAgregarCliente);
            this.Controls.Add(this.dgvCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDireccionCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtApellidosCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombreCliente);
            this.Controls.Add(this.Codigo);
            this.Controls.Add(this.txtCodCliente);
            this.Name = "FrmCliente";
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodCliente;
        private System.Windows.Forms.Label Codigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtApellidosCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDireccionCliente;
        private System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.Button btnAgregarCliente;
        private System.Windows.Forms.Button btnEliminarCliente;
        private System.Windows.Forms.Button btnConsultarCliente;
        private System.Windows.Forms.Button btnAtrasCliente;
    }
}