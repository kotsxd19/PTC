namespace Proyecto.Vista.Mascota
{
    partial class frmRazaGatos
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnIngresarRazaGatos = new System.Windows.Forms.Button();
            this.dgvRazaGatos = new System.Windows.Forms.DataGridView();
            this.txtIngresaRazaGatos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBuscarProveedor = new System.Windows.Forms.Button();
            this.txtBuscadorRaza = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRazaGatos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnBuscarProveedor);
            this.panel1.Controls.Add(this.txtBuscadorRaza);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnIngresarRazaGatos);
            this.panel1.Controls.Add(this.dgvRazaGatos);
            this.panel1.Controls.Add(this.txtIngresaRazaGatos);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(478, 532);
            this.panel1.TabIndex = 1;
            // 
            // btnIngresarRazaGatos
            // 
            this.btnIngresarRazaGatos.Location = new System.Drawing.Point(15, 100);
            this.btnIngresarRazaGatos.Name = "btnIngresarRazaGatos";
            this.btnIngresarRazaGatos.Size = new System.Drawing.Size(94, 23);
            this.btnIngresarRazaGatos.TabIndex = 3;
            this.btnIngresarRazaGatos.Text = "Ingresar";
            this.btnIngresarRazaGatos.UseVisualStyleBackColor = true;
            // 
            // dgvRazaGatos
            // 
            this.dgvRazaGatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRazaGatos.Location = new System.Drawing.Point(3, 194);
            this.dgvRazaGatos.Name = "dgvRazaGatos";
            this.dgvRazaGatos.Size = new System.Drawing.Size(472, 335);
            this.dgvRazaGatos.TabIndex = 2;
            // 
            // txtIngresaRazaGatos
            // 
            this.txtIngresaRazaGatos.Location = new System.Drawing.Point(15, 60);
            this.txtIngresaRazaGatos.Name = "txtIngresaRazaGatos";
            this.txtIngresaRazaGatos.Size = new System.Drawing.Size(445, 20);
            this.txtIngresaRazaGatos.TabIndex = 1;
            this.txtIngresaRazaGatos.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese nueva Raza";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Buscar mascota:";
            // 
            // btnBuscarProveedor
            // 
            this.btnBuscarProveedor.FlatAppearance.BorderSize = 0;
            this.btnBuscarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarProveedor.Image = global::Proyecto.Properties.Resources.icons8_buscar_30;
            this.btnBuscarProveedor.Location = new System.Drawing.Point(421, 163);
            this.btnBuscarProveedor.Name = "btnBuscarProveedor";
            this.btnBuscarProveedor.Size = new System.Drawing.Size(35, 29);
            this.btnBuscarProveedor.TabIndex = 10;
            this.btnBuscarProveedor.UseVisualStyleBackColor = true;
            // 
            // txtBuscadorRaza
            // 
            this.txtBuscadorRaza.Location = new System.Drawing.Point(123, 168);
            this.txtBuscadorRaza.Name = "txtBuscadorRaza";
            this.txtBuscadorRaza.Size = new System.Drawing.Size(292, 20);
            this.txtBuscadorRaza.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(365, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "(Seleccione la Raza)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(221, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Razas";
            // 
            // frmRazaGatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(504, 556);
            this.Controls.Add(this.panel1);
            this.Name = "frmRazaGatos";
            this.Text = "frmRazaGatos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRazaGatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnIngresarRazaGatos;
        private System.Windows.Forms.DataGridView dgvRazaGatos;
        private System.Windows.Forms.TextBox txtIngresaRazaGatos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Button btnBuscarProveedor;
        public System.Windows.Forms.TextBox txtBuscadorRaza;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}