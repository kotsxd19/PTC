namespace Proyecto.Vista.citas
{
    partial class frmRegtistrocitas
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.cbEstadoCitas = new System.Windows.Forms.CheckBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnNuevaCita = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscador = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(251)))), ((int)(((byte)(225)))));
            this.panel4.Controls.Add(this.cbEstadoCitas);
            this.panel4.Controls.Add(this.btnActualizar);
            this.panel4.Controls.Add(this.btnNuevaCita);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.btnBuscar);
            this.panel4.Controls.Add(this.txtBuscador);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1207, 69);
            this.panel4.TabIndex = 5;
            // 
            // cbEstadoCitas
            // 
            this.cbEstadoCitas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbEstadoCitas.AutoSize = true;
            this.cbEstadoCitas.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbEstadoCitas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbEstadoCitas.Location = new System.Drawing.Point(795, 27);
            this.cbEstadoCitas.Margin = new System.Windows.Forms.Padding(4);
            this.cbEstadoCitas.Name = "cbEstadoCitas";
            this.cbEstadoCitas.Size = new System.Drawing.Size(115, 20);
            this.cbEstadoCitas.TabIndex = 9;
            this.cbEstadoCitas.Text = "Citas Inactivos";
            this.cbEstadoCitas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbEstadoCitas.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(112)))), ((int)(((byte)(119)))));
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Image = global::Proyecto.Properties.Resources.icons8_actualizar_45;
            this.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizar.Location = new System.Drawing.Point(931, 10);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(131, 48);
            this.btnActualizar.TabIndex = 8;
            this.btnActualizar.Text = "actualizar";
            this.btnActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnNuevaCita
            // 
            this.btnNuevaCita.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevaCita.FlatAppearance.BorderSize = 0;
            this.btnNuevaCita.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(112)))), ((int)(((byte)(119)))));
            this.btnNuevaCita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevaCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaCita.Image = global::Proyecto.Properties.Resources.icons8_añadir_35;
            this.btnNuevaCita.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevaCita.Location = new System.Drawing.Point(1085, 10);
            this.btnNuevaCita.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevaCita.Name = "btnNuevaCita";
            this.btnNuevaCita.Size = new System.Drawing.Size(109, 48);
            this.btnNuevaCita.TabIndex = 8;
            this.btnNuevaCita.Text = "Nuevo";
            this.btnNuevaCita.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevaCita.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Buscar empleado:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Image = global::Proyecto.Properties.Resources.icons8_buscar_30;
            this.btnBuscar.Location = new System.Drawing.Point(541, 18);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(47, 36);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtBuscador
            // 
            this.txtBuscador.Location = new System.Drawing.Point(144, 25);
            this.txtBuscador.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscador.Name = "txtBuscador";
            this.txtBuscador.Size = new System.Drawing.Size(388, 22);
            this.txtBuscador.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(251)))), ((int)(((byte)(225)))));
            this.panel3.Controls.Add(this.dgvEmpleados);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 69);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.panel3.Size = new System.Drawing.Size(1207, 575);
            this.panel3.TabIndex = 7;
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEmpleados.Location = new System.Drawing.Point(13, 12);
            this.dgvEmpleados.Margin = new System.Windows.Forms.Padding(4);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.RowHeadersWidth = 51;
            this.dgvEmpleados.Size = new System.Drawing.Size(1181, 551);
            this.dgvEmpleados.TabIndex = 0;
            // 
            // frmRegtistrocitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 644);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Name = "frmRegtistrocitas";
            this.Text = "frmRegtistrocitas";
            this.Load += new System.EventHandler(this.frmRegtistrocitas_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.CheckBox cbEstadoCitas;
        public System.Windows.Forms.Button btnActualizar;
        public System.Windows.Forms.Button btnNuevaCita;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnBuscar;
        public System.Windows.Forms.TextBox txtBuscador;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.DataGridView dgvEmpleados;
    }
}