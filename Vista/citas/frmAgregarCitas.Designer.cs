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
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnActualizarProveedor = new System.Windows.Forms.Button();
            this.btnNuevoProveedor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscarProveedor = new System.Windows.Forms.Button();
            this.txtBuscadorProveedor = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvProveedor = new System.Windows.Forms.DataGridView();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedor)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(251)))), ((int)(((byte)(225)))));
            this.panel4.Controls.Add(this.btnActualizarProveedor);
            this.panel4.Controls.Add(this.btnNuevoProveedor);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.btnBuscarProveedor);
            this.panel4.Controls.Add(this.txtBuscadorProveedor);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(986, 56);
            this.panel4.TabIndex = 6;
            // 
            // btnActualizarProveedor
            // 
            this.btnActualizarProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizarProveedor.FlatAppearance.BorderSize = 0;
            this.btnActualizarProveedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(112)))), ((int)(((byte)(119)))));
            this.btnActualizarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarProveedor.Image = global::Proyecto.Properties.Resources.icons8_añadir_35;
            this.btnActualizarProveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizarProveedor.Location = new System.Drawing.Point(748, 10);
            this.btnActualizarProveedor.Name = "btnActualizarProveedor";
            this.btnActualizarProveedor.Size = new System.Drawing.Size(114, 39);
            this.btnActualizarProveedor.TabIndex = 8;
            this.btnActualizarProveedor.Text = "actualizar";
            this.btnActualizarProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnActualizarProveedor.UseVisualStyleBackColor = true;
            // 
            // btnNuevoProveedor
            // 
            this.btnNuevoProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevoProveedor.FlatAppearance.BorderSize = 0;
            this.btnNuevoProveedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(112)))), ((int)(((byte)(119)))));
            this.btnNuevoProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoProveedor.Image = global::Proyecto.Properties.Resources.icons8_calendario_30__1_;
            this.btnNuevoProveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoProveedor.Location = new System.Drawing.Point(868, 8);
            this.btnNuevoProveedor.Name = "btnNuevoProveedor";
            this.btnNuevoProveedor.Size = new System.Drawing.Size(108, 39);
            this.btnNuevoProveedor.TabIndex = 8;
            this.btnNuevoProveedor.Text = "Nuevo";
            this.btnNuevoProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevoProveedor.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Buscar empleado:";
            // 
            // btnBuscarProveedor
            // 
            this.btnBuscarProveedor.FlatAppearance.BorderSize = 0;
            this.btnBuscarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarProveedor.Image = global::Proyecto.Properties.Resources.icons8_buscar_30;
            this.btnBuscarProveedor.Location = new System.Drawing.Point(406, 15);
            this.btnBuscarProveedor.Name = "btnBuscarProveedor";
            this.btnBuscarProveedor.Size = new System.Drawing.Size(35, 29);
            this.btnBuscarProveedor.TabIndex = 1;
            this.btnBuscarProveedor.UseVisualStyleBackColor = true;
            // 
            // txtBuscadorProveedor
            // 
            this.txtBuscadorProveedor.Location = new System.Drawing.Point(108, 20);
            this.txtBuscadorProveedor.Name = "txtBuscadorProveedor";
            this.txtBuscadorProveedor.Size = new System.Drawing.Size(292, 20);
            this.txtBuscadorProveedor.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(251)))), ((int)(((byte)(225)))));
            this.panel3.Controls.Add(this.dgvProveedor);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 56);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(10);
            this.panel3.Size = new System.Drawing.Size(986, 474);
            this.panel3.TabIndex = 8;
            // 
            // dgvProveedor
            // 
            this.dgvProveedor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProveedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProveedor.Location = new System.Drawing.Point(10, 10);
            this.dgvProveedor.Name = "dgvProveedor";
            this.dgvProveedor.RowHeadersWidth = 51;
            this.dgvProveedor.Size = new System.Drawing.Size(966, 454);
            this.dgvProveedor.TabIndex = 0;
            // 
            // frmAgregarCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 530);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Name = "frmAgregarCitas";
            this.Text = "frmAgregarCitas";
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.Button btnActualizarProveedor;
        public System.Windows.Forms.Button btnNuevoProveedor;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnBuscarProveedor;
        public System.Windows.Forms.TextBox txtBuscadorProveedor;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.DataGridView dgvProveedor;
    }
}