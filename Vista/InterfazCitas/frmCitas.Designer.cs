namespace Proyecto.Vista.InterfazCitas
{
    partial class frmCitas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCitas));
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnEliminarCita = new System.Windows.Forms.Button();
            this.btnIngresarCita = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.btnCitas = new System.Windows.Forms.Button();
            this.btnProducto = new System.Windows.Forms.Button();
            this.btnHistorialMascota = new System.Windows.Forms.Button();
            this.btnRegistroEmpleados = new System.Windows.Forms.Button();
            this.btnIngresoMascota = new System.Windows.Forms.Button();
            this.btnIngresoNevoEmpleado = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.MenuCitas = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsEliminarCita = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvInfoCitas = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvCitas = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.MenuCitas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfoCitas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(228)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.btnImprimir);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.btnEliminarCita);
            this.panel1.Controls.Add(this.btnIngresarCita);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1413, 116);
            this.panel1.TabIndex = 0;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(942, 59);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(95, 20);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnEliminarCita
            // 
            this.btnEliminarCita.BackColor = System.Drawing.Color.White;
            this.btnEliminarCita.Location = new System.Drawing.Point(1233, 46);
            this.btnEliminarCita.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarCita.Name = "btnEliminarCita";
            this.btnEliminarCita.Size = new System.Drawing.Size(131, 42);
            this.btnEliminarCita.TabIndex = 2;
            this.btnEliminarCita.Text = "Eliminar Cita";
            this.btnEliminarCita.UseVisualStyleBackColor = false;
            // 
            // btnIngresarCita
            // 
            this.btnIngresarCita.BackColor = System.Drawing.Color.White;
            this.btnIngresarCita.Location = new System.Drawing.Point(1077, 47);
            this.btnIngresarCita.Margin = new System.Windows.Forms.Padding(4);
            this.btnIngresarCita.Name = "btnIngresarCita";
            this.btnIngresarCita.Size = new System.Drawing.Size(131, 42);
            this.btnIngresarCita.TabIndex = 1;
            this.btnIngresarCita.Text = "Ingresar Cita";
            this.btnIngresarCita.UseVisualStyleBackColor = false;
            this.btnIngresarCita.Click += new System.EventHandler(this.btnIngresarCita_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(271, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "VetManager";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(206)))), ((int)(((byte)(175)))));
            this.flowLayoutPanel1.Controls.Add(this.pictureBox1);
            this.flowLayoutPanel1.Controls.Add(this.btnUsuario);
            this.flowLayoutPanel1.Controls.Add(this.btnCitas);
            this.flowLayoutPanel1.Controls.Add(this.btnProducto);
            this.flowLayoutPanel1.Controls.Add(this.btnHistorialMascota);
            this.flowLayoutPanel1.Controls.Add(this.btnRegistroEmpleados);
            this.flowLayoutPanel1.Controls.Add(this.btnIngresoMascota);
            this.flowLayoutPanel1.Controls.Add(this.btnIngresoNevoEmpleado);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 116);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(212, 654);
            this.flowLayoutPanel1.TabIndex = 1;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(205, 111);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnUsuario
            // 
            this.btnUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(206)))), ((int)(((byte)(175)))));
            this.btnUsuario.Location = new System.Drawing.Point(4, 131);
            this.btnUsuario.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(205, 59);
            this.btnUsuario.TabIndex = 0;
            this.btnUsuario.Text = "Usuario";
            this.btnUsuario.UseVisualStyleBackColor = false;
            // 
            // btnCitas
            // 
            this.btnCitas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(206)))), ((int)(((byte)(175)))));
            this.btnCitas.Location = new System.Drawing.Point(4, 206);
            this.btnCitas.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.btnCitas.Name = "btnCitas";
            this.btnCitas.Size = new System.Drawing.Size(205, 59);
            this.btnCitas.TabIndex = 0;
            this.btnCitas.Text = "Citas";
            this.btnCitas.UseVisualStyleBackColor = false;
            // 
            // btnProducto
            // 
            this.btnProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(206)))), ((int)(((byte)(175)))));
            this.btnProducto.Location = new System.Drawing.Point(4, 281);
            this.btnProducto.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.btnProducto.Name = "btnProducto";
            this.btnProducto.Size = new System.Drawing.Size(205, 59);
            this.btnProducto.TabIndex = 0;
            this.btnProducto.Text = "Producto";
            this.btnProducto.UseVisualStyleBackColor = false;
            // 
            // btnHistorialMascota
            // 
            this.btnHistorialMascota.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(206)))), ((int)(((byte)(175)))));
            this.btnHistorialMascota.Location = new System.Drawing.Point(4, 356);
            this.btnHistorialMascota.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.btnHistorialMascota.Name = "btnHistorialMascota";
            this.btnHistorialMascota.Size = new System.Drawing.Size(205, 59);
            this.btnHistorialMascota.TabIndex = 0;
            this.btnHistorialMascota.Text = "Historial de la Mascota";
            this.btnHistorialMascota.UseVisualStyleBackColor = false;
            // 
            // btnRegistroEmpleados
            // 
            this.btnRegistroEmpleados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(206)))), ((int)(((byte)(175)))));
            this.btnRegistroEmpleados.Location = new System.Drawing.Point(4, 431);
            this.btnRegistroEmpleados.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.btnRegistroEmpleados.Name = "btnRegistroEmpleados";
            this.btnRegistroEmpleados.Size = new System.Drawing.Size(205, 59);
            this.btnRegistroEmpleados.TabIndex = 0;
            this.btnRegistroEmpleados.Text = "Registro de Empleados";
            this.btnRegistroEmpleados.UseVisualStyleBackColor = false;
            this.btnRegistroEmpleados.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnIngresoMascota
            // 
            this.btnIngresoMascota.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(206)))), ((int)(((byte)(175)))));
            this.btnIngresoMascota.Location = new System.Drawing.Point(4, 506);
            this.btnIngresoMascota.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.btnIngresoMascota.Name = "btnIngresoMascota";
            this.btnIngresoMascota.Size = new System.Drawing.Size(205, 59);
            this.btnIngresoMascota.TabIndex = 0;
            this.btnIngresoMascota.Text = "Ingreso de Mascotas";
            this.btnIngresoMascota.UseVisualStyleBackColor = false;
            // 
            // btnIngresoNevoEmpleado
            // 
            this.btnIngresoNevoEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(206)))), ((int)(((byte)(175)))));
            this.btnIngresoNevoEmpleado.Location = new System.Drawing.Point(4, 581);
            this.btnIngresoNevoEmpleado.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.btnIngresoNevoEmpleado.Name = "btnIngresoNevoEmpleado";
            this.btnIngresoNevoEmpleado.Size = new System.Drawing.Size(205, 59);
            this.btnIngresoNevoEmpleado.TabIndex = 0;
            this.btnIngresoNevoEmpleado.Text = "Ingreso de nuevo empleado";
            this.btnIngresoNevoEmpleado.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(212, 116);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1201, 58);
            this.panel2.TabIndex = 3;
            // 
            // MenuCitas
            // 
            this.MenuCitas.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuCitas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsEliminarCita});
            this.MenuCitas.Name = "MenuCitas";
            this.MenuCitas.Size = new System.Drawing.Size(159, 28);
            this.MenuCitas.Opening += new System.ComponentModel.CancelEventHandler(this.MenuCitas_Opening);
            // 
            // cmsEliminarCita
            // 
            this.cmsEliminarCita.Name = "cmsEliminarCita";
            this.cmsEliminarCita.Size = new System.Drawing.Size(158, 24);
            this.cmsEliminarCita.Text = "EliminarCita";
            // 
            // dgvInfoCitas
            // 
            this.dgvInfoCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfoCitas.ContextMenuStrip = this.MenuCitas;
            this.dgvInfoCitas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInfoCitas.Location = new System.Drawing.Point(212, 174);
            this.dgvInfoCitas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvInfoCitas.Name = "dgvInfoCitas";
            this.dgvInfoCitas.RowHeadersWidth = 51;
            this.dgvInfoCitas.RowTemplate.Height = 24;
            this.dgvInfoCitas.Size = new System.Drawing.Size(1201, 596);
            this.dgvInfoCitas.TabIndex = 6;
            this.dgvInfoCitas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInfoCitas_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(311, 321);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 20);
            this.label6.TabIndex = 18;
            // 
            // dgvCitas
            // 
            this.dgvCitas.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCitas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCitas.Location = new System.Drawing.Point(212, 116);
            this.dgvCitas.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCitas.Name = "dgvCitas";
            this.dgvCitas.RowHeadersWidth = 51;
            this.dgvCitas.Size = new System.Drawing.Size(1201, 654);
            this.dgvCitas.TabIndex = 2;
            this.dgvCitas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.ImprimirCitas);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(770, 59);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(133, 30);
            this.btnImprimir.TabIndex = 4;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // frmCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1413, 770);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvInfoCitas);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvCitas);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCitas";
            this.Text = "frmCitas";
            this.Load += new System.EventHandler(this.frmCitas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.MenuCitas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfoCitas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.ContextMenuStrip MenuCitas;
        public System.Windows.Forms.ToolStripMenuItem cmsEliminarCita;
        public System.Windows.Forms.Button btnUsuario;
        public System.Windows.Forms.Button btnIngresarCita;
        public System.Windows.Forms.Button btnHistorialMascota;
        public System.Windows.Forms.Button btnProducto;
        public System.Windows.Forms.Button btnCitas;
        public System.Windows.Forms.Button btnIngresoNevoEmpleado;
        public System.Windows.Forms.Button btnIngresoMascota;
        public System.Windows.Forms.Button btnRegistroEmpleados;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.DataGridView dgvCitas;
        public System.Windows.Forms.Button btnEliminarCita;
        public System.Windows.Forms.DataGridView dgvInfoCitas;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        public System.Windows.Forms.Button btnImprimir;
    }
}