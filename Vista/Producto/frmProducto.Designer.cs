namespace Proyecto.Vista.Producto
{
    partial class frmProducto
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
            this.cbEstado = new System.Windows.Forms.CheckBox();
            this.btnActualizarProveedor = new System.Windows.Forms.Button();
            this.btnNuevoProductos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.txtBuscarProducto = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.btnImprimirProducto = new System.Windows.Forms.Button();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(251)))), ((int)(((byte)(225)))));
            this.panel4.Controls.Add(this.btnImprimirProducto);
            this.panel4.Controls.Add(this.cbEstado);
            this.panel4.Controls.Add(this.btnActualizarProveedor);
            this.panel4.Controls.Add(this.btnNuevoProductos);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.btnBuscarProducto);
            this.panel4.Controls.Add(this.txtBuscarProducto);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1567, 69);
            this.panel4.TabIndex = 7;
            // 
            // cbEstado
            // 
            this.cbEstado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbEstado.AutoSize = true;
            this.cbEstado.Location = new System.Drawing.Point(1096, 28);
            this.cbEstado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(146, 20);
            this.cbEstado.TabIndex = 10;
            this.cbEstado.Text = "Productos Inactivos";
            this.cbEstado.UseVisualStyleBackColor = true;
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
            this.btnActualizarProveedor.Location = new System.Drawing.Point(1249, 12);
            this.btnActualizarProveedor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnActualizarProveedor.Name = "btnActualizarProveedor";
            this.btnActualizarProveedor.Size = new System.Drawing.Size(152, 48);
            this.btnActualizarProveedor.TabIndex = 8;
            this.btnActualizarProveedor.Text = "actualizar";
            this.btnActualizarProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnActualizarProveedor.UseVisualStyleBackColor = true;
            // 
            // btnNuevoProductos
            // 
            this.btnNuevoProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevoProductos.FlatAppearance.BorderSize = 0;
            this.btnNuevoProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(112)))), ((int)(((byte)(119)))));
            this.btnNuevoProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoProductos.Image = global::Proyecto.Properties.Resources.icons8_agregar_producto_35;
            this.btnNuevoProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoProductos.Location = new System.Drawing.Point(1409, 10);
            this.btnNuevoProductos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNuevoProductos.Name = "btnNuevoProductos";
            this.btnNuevoProductos.Size = new System.Drawing.Size(144, 48);
            this.btnNuevoProductos.TabIndex = 8;
            this.btnNuevoProductos.Text = "Nuevo";
            this.btnNuevoProductos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevoProductos.UseVisualStyleBackColor = true;
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
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.FlatAppearance.BorderSize = 0;
            this.btnBuscarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarProducto.Image = global::Proyecto.Properties.Resources.icons8_buscar_30;
            this.btnBuscarProducto.Location = new System.Drawing.Point(541, 18);
            this.btnBuscarProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(47, 36);
            this.btnBuscarProducto.TabIndex = 1;
            this.btnBuscarProducto.UseVisualStyleBackColor = true;
            // 
            // txtBuscarProducto
            // 
            this.txtBuscarProducto.Location = new System.Drawing.Point(144, 25);
            this.txtBuscarProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBuscarProducto.Name = "txtBuscarProducto";
            this.txtBuscarProducto.Size = new System.Drawing.Size(388, 22);
            this.txtBuscarProducto.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(251)))), ((int)(((byte)(225)))));
            this.panel3.Controls.Add(this.dgvProductos);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 69);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.panel3.Size = new System.Drawing.Size(1567, 614);
            this.panel3.TabIndex = 9;
            // 
            // dgvProductos
            // 
            this.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProductos.Location = new System.Drawing.Point(13, 12);
            this.dgvProductos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.RowHeadersWidth = 51;
            this.dgvProductos.Size = new System.Drawing.Size(1541, 590);
            this.dgvProductos.TabIndex = 0;
            this.dgvProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProveedor_CellContentClick);
            // 
            // btnImprimirProducto
            // 
            this.btnImprimirProducto.Location = new System.Drawing.Point(909, 19);
            this.btnImprimirProducto.Name = "btnImprimirProducto";
            this.btnImprimirProducto.Size = new System.Drawing.Size(124, 37);
            this.btnImprimirProducto.TabIndex = 11;
            this.btnImprimirProducto.Text = "Imprimir Producto";
            this.btnImprimirProducto.UseVisualStyleBackColor = true;
            // 
            // frmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1567, 683);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmProducto";
            this.Text = "frmProducto";
            this.Load += new System.EventHandler(this.frmProducto_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.Button btnActualizarProveedor;
        public System.Windows.Forms.Button btnNuevoProductos;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnBuscarProducto;
        public System.Windows.Forms.TextBox txtBuscarProducto;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.DataGridView dgvProductos;
        public System.Windows.Forms.CheckBox cbEstado;
        private System.Windows.Forms.Button btnImprimirProducto;
    }
}