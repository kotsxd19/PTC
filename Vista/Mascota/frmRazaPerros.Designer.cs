namespace Proyecto.Vista.Mascota
{
    partial class frmRazaPerros
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
            this.btnIngresarRazaPerro = new System.Windows.Forms.Button();
            this.dgvRazaPerros = new System.Windows.Forms.DataGridView();
            this.txtRazaPerros = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBuscarProveedor = new System.Windows.Forms.Button();
            this.txtBuscadorRaza = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRazaPerros)).BeginInit();
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
            this.panel1.Controls.Add(this.btnIngresarRazaPerro);
            this.panel1.Controls.Add(this.dgvRazaPerros);
            this.panel1.Controls.Add(this.txtRazaPerros);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(478, 538);
            this.panel1.TabIndex = 0;
            // 
            // btnIngresarRazaPerro
            // 
            this.btnIngresarRazaPerro.Location = new System.Drawing.Point(15, 100);
            this.btnIngresarRazaPerro.Name = "btnIngresarRazaPerro";
            this.btnIngresarRazaPerro.Size = new System.Drawing.Size(94, 23);
            this.btnIngresarRazaPerro.TabIndex = 3;
            this.btnIngresarRazaPerro.Text = "Ingresar";
            this.btnIngresarRazaPerro.UseVisualStyleBackColor = true;
            // 
            // dgvRazaPerros
            // 
            this.dgvRazaPerros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRazaPerros.Location = new System.Drawing.Point(3, 199);
            this.dgvRazaPerros.Name = "dgvRazaPerros";
            this.dgvRazaPerros.Size = new System.Drawing.Size(472, 336);
            this.dgvRazaPerros.TabIndex = 2;
            // 
            // txtRazaPerros
            // 
            this.txtRazaPerros.Location = new System.Drawing.Point(15, 60);
            this.txtRazaPerros.Name = "txtRazaPerros";
            this.txtRazaPerros.Size = new System.Drawing.Size(445, 20);
            this.txtRazaPerros.TabIndex = 1;
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
            this.label4.Location = new System.Drawing.Point(12, 176);
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
            this.btnBuscarProveedor.Location = new System.Drawing.Point(422, 168);
            this.btnBuscarProveedor.Name = "btnBuscarProveedor";
            this.btnBuscarProveedor.Size = new System.Drawing.Size(35, 29);
            this.btnBuscarProveedor.TabIndex = 10;
            this.btnBuscarProveedor.UseVisualStyleBackColor = true;
            // 
            // txtBuscadorRaza
            // 
            this.txtBuscadorRaza.Location = new System.Drawing.Point(124, 173);
            this.txtBuscadorRaza.Name = "txtBuscadorRaza";
            this.txtBuscadorRaza.Size = new System.Drawing.Size(292, 20);
            this.txtBuscadorRaza.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(366, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "(Seleccione la Raza)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(222, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Razas";
            // 
            // frmRazaPerros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(503, 563);
            this.Controls.Add(this.panel1);
            this.Name = "frmRazaPerros";
            this.Text = "frmRazaPerros";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRazaPerros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvRazaPerros;
        private System.Windows.Forms.TextBox txtRazaPerros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIngresarRazaPerro;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Button btnBuscarProveedor;
        public System.Windows.Forms.TextBox txtBuscadorRaza;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}