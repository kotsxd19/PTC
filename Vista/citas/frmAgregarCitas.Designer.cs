namespace Proyecto.Vista.citas
{
    partial class frmAgregarCitas
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
            this.components = new System.ComponentModel.Container();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnActualizarCita = new System.Windows.Forms.Button();
            this.btnNuevaCita = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscarProveedor = new System.Windows.Forms.Button();
            this.txtBuscadorProveedor = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvCitas = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitas)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(251)))), ((int)(((byte)(225)))));
            this.panel4.Controls.Add(this.checkBox1);
            this.panel4.Controls.Add(this.btnActualizarCita);
            this.panel4.Controls.Add(this.btnNuevaCita);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.btnBuscarProveedor);
            this.panel4.Controls.Add(this.txtBuscadorProveedor);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1315, 69);
            this.panel4.TabIndex = 6;
            // 
            // btnActualizarCita
            // 
            this.btnActualizarCita.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizarCita.FlatAppearance.BorderSize = 0;
            this.btnActualizarCita.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(112)))), ((int)(((byte)(119)))));
            this.btnActualizarCita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarCita.Image = global::Proyecto.Properties.Resources.icons8_añadir_35;
            this.btnActualizarCita.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizarCita.Location = new System.Drawing.Point(997, 12);
            this.btnActualizarCita.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnActualizarCita.Name = "btnActualizarCita";
            this.btnActualizarCita.Size = new System.Drawing.Size(152, 48);
            this.btnActualizarCita.TabIndex = 8;
            this.btnActualizarCita.Text = "actualizar";
            this.btnActualizarCita.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnActualizarCita.UseVisualStyleBackColor = true;
            // 
            // btnNuevaCita
            // 
            this.btnNuevaCita.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevaCita.FlatAppearance.BorderSize = 0;
            this.btnNuevaCita.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(112)))), ((int)(((byte)(119)))));
            this.btnNuevaCita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevaCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaCita.Image = global::Proyecto.Properties.Resources.icons8_calendario_30__1_;
            this.btnNuevaCita.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevaCita.Location = new System.Drawing.Point(1157, 10);
            this.btnNuevaCita.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNuevaCita.Name = "btnNuevaCita";
            this.btnNuevaCita.Size = new System.Drawing.Size(144, 48);
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
            // btnBuscarProveedor
            // 
            this.btnBuscarProveedor.FlatAppearance.BorderSize = 0;
            this.btnBuscarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarProveedor.Image = global::Proyecto.Properties.Resources.icons8_buscar_30;
            this.btnBuscarProveedor.Location = new System.Drawing.Point(541, 18);
            this.btnBuscarProveedor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscarProveedor.Name = "btnBuscarProveedor";
            this.btnBuscarProveedor.Size = new System.Drawing.Size(47, 36);
            this.btnBuscarProveedor.TabIndex = 1;
            this.btnBuscarProveedor.UseVisualStyleBackColor = true;
            // 
            // txtBuscadorProveedor
            // 
            this.txtBuscadorProveedor.Location = new System.Drawing.Point(144, 25);
            this.txtBuscadorProveedor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBuscadorProveedor.Name = "txtBuscadorProveedor";
            this.txtBuscadorProveedor.Size = new System.Drawing.Size(388, 22);
            this.txtBuscadorProveedor.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(251)))), ((int)(((byte)(225)))));
            this.panel3.Controls.Add(this.dgvCitas);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 69);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.panel3.Size = new System.Drawing.Size(1315, 583);
            this.panel3.TabIndex = 8;
            // 
            // dgvCitas
            // 
            this.dgvCitas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCitas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCitas.Location = new System.Drawing.Point(13, 12);
            this.dgvCitas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvCitas.Name = "dgvCitas";
            this.dgvCitas.RowHeadersWidth = 51;
            this.dgvCitas.Size = new System.Drawing.Size(1289, 559);
            this.dgvCitas.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eliminarToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(133, 28);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.eliminarToolStripMenuItem.Text = "eliminar";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(883, 28);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(95, 20);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // frmAgregarCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1315, 652);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmAgregarCitas";
            this.Text = "frmAgregarCitas";
            this.Load += new System.EventHandler(this.frmAgregarCitas_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitas)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.Button btnActualizarCita;
        public System.Windows.Forms.Button btnNuevaCita;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnBuscarProveedor;
        public System.Windows.Forms.TextBox txtBuscadorProveedor;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.DataGridView dgvCitas;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        public System.Windows.Forms.CheckBox checkBox1;
    }
}