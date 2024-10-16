namespace Proyecto.Vista.Producto
{
    partial class frmAgregarProducto
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
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnActualizarProducto = new System.Windows.Forms.Button();
            this.btnIngresarProducto = new System.Windows.Forms.Button();
            this.cmbProveedor = new System.Windows.Forms.ComboBox();
            this.txtCodigoDeBarra = new System.Windows.Forms.TextBox();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.cmbEstado);
            this.panel1.Controls.Add(this.txtPrecio);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.cmbProveedor);
            this.panel1.Controls.Add(this.txtCodigoDeBarra);
            this.panel1.Controls.Add(this.txtNombreProducto);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(430, 350);
            this.panel1.TabIndex = 1;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(16, 234);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(146, 20);
            this.txtPrecio.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.btnCancelar);
            this.panel4.Controls.Add(this.btnActualizarProducto);
            this.panel4.Controls.Add(this.btnIngresarProducto);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 282);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(430, 68);
            this.panel4.TabIndex = 5;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(225)))), ((int)(((byte)(202)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(251)))), ((int)(((byte)(225)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancelar.Location = new System.Drawing.Point(17, 8);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(109, 40);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnActualizarProducto
            // 
            this.btnActualizarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(225)))), ((int)(((byte)(202)))));
            this.btnActualizarProducto.FlatAppearance.BorderSize = 0;
            this.btnActualizarProducto.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnActualizarProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(251)))), ((int)(((byte)(225)))));
            this.btnActualizarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarProducto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnActualizarProducto.Location = new System.Drawing.Point(178, 10);
            this.btnActualizarProducto.Name = "btnActualizarProducto";
            this.btnActualizarProducto.Size = new System.Drawing.Size(114, 40);
            this.btnActualizarProducto.TabIndex = 9;
            this.btnActualizarProducto.Text = "Actualizar";
            this.btnActualizarProducto.UseVisualStyleBackColor = false;
            // 
            // btnIngresarProducto
            // 
            this.btnIngresarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(225)))), ((int)(((byte)(202)))));
            this.btnIngresarProducto.FlatAppearance.BorderSize = 0;
            this.btnIngresarProducto.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnIngresarProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(251)))), ((int)(((byte)(225)))));
            this.btnIngresarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresarProducto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnIngresarProducto.Location = new System.Drawing.Point(298, 10);
            this.btnIngresarProducto.Name = "btnIngresarProducto";
            this.btnIngresarProducto.Size = new System.Drawing.Size(114, 38);
            this.btnIngresarProducto.TabIndex = 8;
            this.btnIngresarProducto.Text = "Ingresar";
            this.btnIngresarProducto.UseVisualStyleBackColor = false;
            // 
            // cmbProveedor
            // 
            this.cmbProveedor.FormattingEnabled = true;
            this.cmbProveedor.Location = new System.Drawing.Point(16, 102);
            this.cmbProveedor.Name = "cmbProveedor";
            this.cmbProveedor.Size = new System.Drawing.Size(321, 21);
            this.cmbProveedor.TabIndex = 3;
            // 
            // txtCodigoDeBarra
            // 
            this.txtCodigoDeBarra.Location = new System.Drawing.Point(16, 177);
            this.txtCodigoDeBarra.Name = "txtCodigoDeBarra";
            this.txtCodigoDeBarra.Size = new System.Drawing.Size(321, 20);
            this.txtCodigoDeBarra.TabIndex = 2;
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(16, 33);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(321, 20);
            this.txtNombreProducto.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Codigo De Barra";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Proveedor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "precio";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(216, 233);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(121, 21);
            this.cmbEstado.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(213, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "estado";
            this.label5.Click += new System.EventHandler(this.label2_Click);
            // 
            // frmAgregarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(112)))), ((int)(((byte)(119)))));
            this.ClientSize = new System.Drawing.Size(454, 374);
            this.Controls.Add(this.panel1);
            this.Name = "frmAgregarProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAgregarProducto";
            this.Load += new System.EventHandler(this.frmAgregarProducto_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.Button btnActualizarProducto;
        public System.Windows.Forms.Button btnIngresarProducto;
        public System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cmbProveedor;
        public System.Windows.Forms.TextBox txtCodigoDeBarra;
        public System.Windows.Forms.TextBox txtNombreProducto;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.ComboBox cmbEstado;
        public System.Windows.Forms.Label label5;
    }
}