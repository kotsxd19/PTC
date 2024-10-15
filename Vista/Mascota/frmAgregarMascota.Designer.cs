namespace Proyecto.Vista.Mascota
{
    partial class frmAgregarMascota
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
            this.btnRaza = new System.Windows.Forms.Button();
            this.nudPeso = new System.Windows.Forms.NumericUpDown();
            this.dgvDueño = new System.Windows.Forms.DataGridView();
            this.btnActualizarMascotas = new System.Windows.Forms.Button();
            this.btnIngresarMascotas = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpNacimiento = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.Nombre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscadorDueño = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPeso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDueño)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.txtBuscadorDueño);
            this.panel1.Controls.Add(this.btnRaza);
            this.panel1.Controls.Add(this.nudPeso);
            this.panel1.Controls.Add(this.dgvDueño);
            this.panel1.Controls.Add(this.btnActualizarMascotas);
            this.panel1.Controls.Add(this.btnIngresarMascotas);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dtpNacimiento);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cmbGenero);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.Nombre);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(487, 572);
            this.panel1.TabIndex = 0;
            // 
            // btnRaza
            // 
            this.btnRaza.Location = new System.Drawing.Point(255, 180);
            this.btnRaza.Name = "btnRaza";
            this.btnRaza.Size = new System.Drawing.Size(142, 23);
            this.btnRaza.TabIndex = 16;
            this.btnRaza.Text = "Razas";
            this.btnRaza.UseVisualStyleBackColor = true;
            // 
            // nudPeso
            // 
            this.nudPeso.Location = new System.Drawing.Point(26, 180);
            this.nudPeso.Name = "nudPeso";
            this.nudPeso.Size = new System.Drawing.Size(173, 20);
            this.nudPeso.TabIndex = 15;
            // 
            // dgvDueño
            // 
            this.dgvDueño.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDueño.Location = new System.Drawing.Point(3, 336);
            this.dgvDueño.Name = "dgvDueño";
            this.dgvDueño.Size = new System.Drawing.Size(481, 166);
            this.dgvDueño.TabIndex = 14;
            this.dgvDueño.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDueño_CellContentClick);
            // 
            // btnActualizarMascotas
            // 
            this.btnActualizarMascotas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(225)))), ((int)(((byte)(202)))));
            this.btnActualizarMascotas.FlatAppearance.BorderSize = 0;
            this.btnActualizarMascotas.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnActualizarMascotas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(251)))), ((int)(((byte)(225)))));
            this.btnActualizarMascotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarMascotas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnActualizarMascotas.Location = new System.Drawing.Point(228, 518);
            this.btnActualizarMascotas.Name = "btnActualizarMascotas";
            this.btnActualizarMascotas.Size = new System.Drawing.Size(114, 40);
            this.btnActualizarMascotas.TabIndex = 12;
            this.btnActualizarMascotas.Text = "Actualizar";
            this.btnActualizarMascotas.UseVisualStyleBackColor = false;
            // 
            // btnIngresarMascotas
            // 
            this.btnIngresarMascotas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(225)))), ((int)(((byte)(202)))));
            this.btnIngresarMascotas.FlatAppearance.BorderSize = 0;
            this.btnIngresarMascotas.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnIngresarMascotas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(251)))), ((int)(((byte)(225)))));
            this.btnIngresarMascotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresarMascotas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnIngresarMascotas.Location = new System.Drawing.Point(359, 519);
            this.btnIngresarMascotas.Name = "btnIngresarMascotas";
            this.btnIngresarMascotas.Size = new System.Drawing.Size(114, 38);
            this.btnIngresarMascotas.TabIndex = 11;
            this.btnIngresarMascotas.Text = "Ingresar";
            this.btnIngresarMascotas.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(256, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Fecha de Nacimiento";
            // 
            // dtpNacimiento
            // 
            this.dtpNacimiento.Location = new System.Drawing.Point(259, 110);
            this.dtpNacimiento.Name = "dtpNacimiento";
            this.dtpNacimiento.Size = new System.Drawing.Size(200, 20);
            this.dtpNacimiento.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Peso(lb)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(215, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Dueño";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Genero";
            // 
            // cmbGenero
            // 
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.Location = new System.Drawing.Point(24, 109);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(175, 21);
            this.cmbGenero.TabIndex = 4;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(27, 51);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(354, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre.Location = new System.Drawing.Point(24, 20);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(58, 17);
            this.Nombre.TabIndex = 0;
            this.Nombre.Text = "Nombre";
            this.Nombre.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Buscar Dueño:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Image = global::Proyecto.Properties.Resources.icons8_buscar_30;
            this.btnBuscar.Location = new System.Drawing.Point(431, 305);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(35, 29);
            this.btnBuscar.TabIndex = 18;
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtBuscadorDueño
            // 
            this.txtBuscadorDueño.Location = new System.Drawing.Point(133, 310);
            this.txtBuscadorDueño.Name = "txtBuscadorDueño";
            this.txtBuscadorDueño.Size = new System.Drawing.Size(292, 20);
            this.txtBuscadorDueño.TabIndex = 17;
            // 
            // frmAgregarMascota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(511, 596);
            this.Controls.Add(this.panel1);
            this.Name = "frmAgregarMascota";
            this.Text = "frmAgregarMascota";
            this.Load += new System.EventHandler(this.frmAgregarMascota_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPeso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDueño)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Nombre;
        public System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button btnIngresarMascotas;
        public System.Windows.Forms.Button btnActualizarMascotas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button btnBuscar;
        public System.Windows.Forms.TextBox txtBuscadorDueño;
        public System.Windows.Forms.ComboBox cmbGenero;
        public System.Windows.Forms.DateTimePicker dtpNacimiento;
        public System.Windows.Forms.Button btnRaza;
        public System.Windows.Forms.NumericUpDown nudPeso;
        public System.Windows.Forms.DataGridView dgvDueño;
    }
}