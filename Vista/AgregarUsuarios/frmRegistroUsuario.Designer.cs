namespace Proyecto.Vista.AgregarUsuarios
{
    partial class frmRegistroUsuario
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
            this.cbEstadoEmpelado = new System.Windows.Forms.CheckBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnNuevoEmpleado = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscador = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvCitas = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsFicha = new System.Windows.Forms.ToolStripMenuItem();
            this.acualizarContraseñaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitas)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(251)))), ((int)(((byte)(225)))));
            this.panel4.Controls.Add(this.cbEstadoEmpelado);
            this.panel4.Controls.Add(this.btnActualizar);
            this.panel4.Controls.Add(this.btnNuevoEmpleado);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.btnBuscar);
            this.panel4.Controls.Add(this.txtBuscador);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1169, 69);
            this.panel4.TabIndex = 4;
            // 
            // cbEstadoEmpelado
            // 
            this.cbEstadoEmpelado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbEstadoEmpelado.AutoSize = true;
            this.cbEstadoEmpelado.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbEstadoEmpelado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbEstadoEmpelado.Location = new System.Drawing.Point(689, 27);
            this.cbEstadoEmpelado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbEstadoEmpelado.Name = "cbEstadoEmpelado";
            this.cbEstadoEmpelado.Size = new System.Drawing.Size(155, 20);
            this.cbEstadoEmpelado.TabIndex = 9;
            this.cbEstadoEmpelado.Text = "Empleados Inactivos";
            this.cbEstadoEmpelado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbEstadoEmpelado.UseVisualStyleBackColor = true;
            this.cbEstadoEmpelado.CheckedChanged += new System.EventHandler(this.cbEstadoEmpelado_CheckedChanged);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(112)))), ((int)(((byte)(119)))));
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Image = global::Proyecto.Properties.Resources.icons8_añadir_35;
            this.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizar.Location = new System.Drawing.Point(852, 12);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(152, 48);
            this.btnActualizar.TabIndex = 8;
            this.btnActualizar.Text = "actualizar";
            this.btnActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnNuevoEmpleado
            // 
            this.btnNuevoEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevoEmpleado.FlatAppearance.BorderSize = 0;
            this.btnNuevoEmpleado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(112)))), ((int)(((byte)(119)))));
            this.btnNuevoEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoEmpleado.Image = global::Proyecto.Properties.Resources.icons8_añadir_35;
            this.btnNuevoEmpleado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoEmpleado.Location = new System.Drawing.Point(1012, 10);
            this.btnNuevoEmpleado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNuevoEmpleado.Name = "btnNuevoEmpleado";
            this.btnNuevoEmpleado.Size = new System.Drawing.Size(144, 48);
            this.btnNuevoEmpleado.TabIndex = 8;
            this.btnNuevoEmpleado.Text = "Nuevo";
            this.btnNuevoEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevoEmpleado.UseVisualStyleBackColor = true;
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
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(47, 36);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtBuscador
            // 
            this.txtBuscador.Location = new System.Drawing.Point(144, 25);
            this.txtBuscador.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBuscador.Name = "txtBuscador";
            this.txtBuscador.Size = new System.Drawing.Size(388, 22);
            this.txtBuscador.TabIndex = 0;
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
            this.panel3.Size = new System.Drawing.Size(1169, 624);
            this.panel3.TabIndex = 6;
            // 
            // dgvCitas
            // 
            this.dgvCitas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCitas.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvCitas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCitas.Location = new System.Drawing.Point(13, 12);
            this.dgvCitas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvCitas.Name = "dgvCitas";
            this.dgvCitas.RowHeadersWidth = 51;
            this.dgvCitas.Size = new System.Drawing.Size(1143, 600);
            this.dgvCitas.TabIndex = 0;
            this.dgvCitas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpleados_CellContentClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsFicha,
            this.acualizarContraseñaToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(222, 56);
            // 
            // cmsFicha
            // 
            this.cmsFicha.Image = global::Proyecto.Properties.Resources.ficha;
            this.cmsFicha.Name = "cmsFicha";
            this.cmsFicha.Size = new System.Drawing.Size(221, 26);
            this.cmsFicha.Text = "Ver ficha";
            // 
            // acualizarContraseñaToolStripMenuItem
            // 
            this.acualizarContraseñaToolStripMenuItem.Image = global::Proyecto.Properties.Resources.d3d904a0_7365_4601_8265_20b2f8fc492b;
            this.acualizarContraseñaToolStripMenuItem.Name = "acualizarContraseñaToolStripMenuItem";
            this.acualizarContraseñaToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.acualizarContraseñaToolStripMenuItem.Text = "Acualizar Contraseña";
            // 
            // frmRegistroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 693);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmRegistroUsuario";
            this.Text = "frmReistoUsuario";
            this.Load += new System.EventHandler(this.frmRegistroUsuario_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitas)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Button btnNuevoEmpleado;
        public System.Windows.Forms.DataGridView dgvCitas;
        public System.Windows.Forms.TextBox txtBuscador;
        public System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        public System.Windows.Forms.ToolStripMenuItem cmsFicha;
        public System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ToolStripMenuItem acualizarContraseñaToolStripMenuItem;
        public System.Windows.Forms.Button btnActualizar;
        public System.Windows.Forms.CheckBox cbEstadoEmpelado;
    }
}