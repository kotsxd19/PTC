namespace Proyecto.Vista.Ventas
{
    partial class frmVentas
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
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnAgregarVenta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscarProveedor = new System.Windows.Forms.Button();
            this.txtBuscadorProveedor = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvVenta = new System.Windows.Forms.DataGridView();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.btnActualizarVenta = new System.Windows.Forms.Button();
            this.cbEstadoAnimal = new System.Windows.Forms.CheckBox();
            this.dgvProveedor = new System.Windows.Forms.DataGridView();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(251)))), ((int)(((byte)(225)))));
            this.panel4.Controls.Add(this.cbEstadoAnimal);
            this.panel4.Controls.Add(this.btnActualizarVenta);
            this.panel4.Controls.Add(this.btnImprimir);
            this.panel4.Controls.Add(this.btnAgregarVenta);

            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.btnBuscarProveedor);
            this.panel4.Controls.Add(this.txtBuscadorProveedor);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);

            this.panel4.Margin = new System.Windows.Forms.Padding(4);

            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1170, 56);
            this.panel4.TabIndex = 8;
            // 
            // btnImprimir
            // 

            this.btnImprimir.Location = new System.Drawing.Point(650, 15);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(101, 28);
            this.btnImprimir.TabIndex = 9;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // btnAgregarVenta
            // 
            this.btnAgregarVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarVenta.FlatAppearance.BorderSize = 0;
            this.btnAgregarVenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(112)))), ((int)(((byte)(119)))));
            this.btnAgregarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarVenta.Image = global::Proyecto.Properties.Resources.icons8_añadir_401;
            this.btnAgregarVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarVenta.Location = new System.Drawing.Point(1047, 10);
            this.btnAgregarVenta.Name = "btnAgregarVenta";
            this.btnAgregarVenta.Size = new System.Drawing.Size(111, 39);
            this.btnAgregarVenta.TabIndex = 8;
            this.btnAgregarVenta.Text = "Agregar";
            this.btnAgregarVenta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarVenta.UseVisualStyleBackColor = true;


            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Buscar Venta:";
            // 
            // btnBuscarProveedor
            // 
            this.btnBuscarProveedor.FlatAppearance.BorderSize = 0;
            this.btnBuscarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarProveedor.Image = global::Proyecto.Properties.Resources.icons8_buscar_30;

            this.btnBuscarProveedor.Location = new System.Drawing.Point(406, 15);

            this.btnBuscarProveedor.Location = new System.Drawing.Point(541, 18);
            this.btnBuscarProveedor.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarProveedor.Name = "btnBuscarProveedor";
            this.btnBuscarProveedor.Size = new System.Drawing.Size(35, 29);
            this.btnBuscarProveedor.TabIndex = 1;
            this.btnBuscarProveedor.UseVisualStyleBackColor = true;
            // 
            // txtBuscadorProveedor
            // 
            this.txtBuscadorProveedor.Location = new System.Drawing.Point(108, 20);

            this.txtBuscadorProveedor.Location = new System.Drawing.Point(144, 25);
            this.txtBuscadorProveedor.Margin = new System.Windows.Forms.Padding(4);

            this.txtBuscadorProveedor.Name = "txtBuscadorProveedor";
            this.txtBuscadorProveedor.Size = new System.Drawing.Size(292, 20);
            this.txtBuscadorProveedor.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(251)))), ((int)(((byte)(225)))));
            this.panel3.Controls.Add(this.dgvVenta);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;

            this.panel3.Location = new System.Drawing.Point(0, 56);

            this.panel3.Location = new System.Drawing.Point(0, 69);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);

            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.panel3.Size = new System.Drawing.Size(1170, 658);
            this.panel3.TabIndex = 10;
            // 
            // dgvVenta
            // 

            this.dgvVenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVenta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVenta.Location = new System.Drawing.Point(10, 10);
            this.dgvVenta.Name = "dgvVenta";
            this.dgvVenta.RowHeadersWidth = 51;
            this.dgvVenta.Size = new System.Drawing.Size(1150, 638);
            this.dgvVenta.TabIndex = 0;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // btnActualizarVenta
            // 
            this.btnActualizarVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizarVenta.FlatAppearance.BorderSize = 0;
            this.btnActualizarVenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(112)))), ((int)(((byte)(119)))));
            this.btnActualizarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarVenta.Image = global::Proyecto.Properties.Resources.icons8_actualizar_45;
            this.btnActualizarVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizarVenta.Location = new System.Drawing.Point(903, 10);
            this.btnActualizarVenta.Name = "btnActualizarVenta";
            this.btnActualizarVenta.Size = new System.Drawing.Size(123, 39);
            this.btnActualizarVenta.TabIndex = 10;
            this.btnActualizarVenta.Text = "actualizar";
            this.btnActualizarVenta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnActualizarVenta.UseVisualStyleBackColor = true;
            // 
            // cbEstadoAnimal
            // 
            this.cbEstadoAnimal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbEstadoAnimal.AutoSize = true;
            this.cbEstadoAnimal.Location = new System.Drawing.Point(793, 23);
            this.cbEstadoAnimal.Name = "cbEstadoAnimal";
            this.cbEstadoAnimal.Size = new System.Drawing.Size(94, 17);
            this.cbEstadoAnimal.TabIndex = 11;
            this.cbEstadoAnimal.Text = "citas Inactivas";
            this.cbEstadoAnimal.UseVisualStyleBackColor = true;

            this.dgvProveedor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProveedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProveedor.Location = new System.Drawing.Point(13, 12);
            this.dgvProveedor.Margin = new System.Windows.Forms.Padding(4);
            this.dgvProveedor.Name = "dgvProveedor";
            this.dgvProveedor.RowHeadersWidth = 51;
            this.dgvProveedor.Size = new System.Drawing.Size(1534, 786);
            this.dgvProveedor.TabIndex = 0;

            // 
            // frmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 714);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);

            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmVentas";
            this.Text = "frmVentas";
            this.Load += new System.EventHandler(this.frmVentas_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.Button btnAgregarVenta;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnBuscarProveedor;
        public System.Windows.Forms.TextBox txtBuscadorProveedor;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.DataGridView dgvVenta;
        public System.Windows.Forms.Button btnImprimir;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        public System.Windows.Forms.Button btnActualizarVenta;
        public System.Windows.Forms.CheckBox cbEstadoAnimal;
        public System.Windows.Forms.DataGridView dgvProveedor;
    }
}