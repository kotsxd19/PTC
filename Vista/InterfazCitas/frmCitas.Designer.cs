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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEliminarCita = new System.Windows.Forms.Button();
            this.btnIngresarCita = new System.Windows.Forms.Button();
            this.btnEditarCita = new System.Windows.Forms.Button();
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
            this.panel1.Controls.Add(this.btnEliminarCita);
            this.panel1.Controls.Add(this.btnIngresarCita);
            this.panel1.Controls.Add(this.btnEditarCita);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1060, 94);
            this.panel1.TabIndex = 0;
            // 
            // btnEliminarCita
            // 
            this.btnEliminarCita.BackColor = System.Drawing.Color.White;
            this.btnEliminarCita.Location = new System.Drawing.Point(925, 37);
            this.btnEliminarCita.Name = "btnEliminarCita";
            this.btnEliminarCita.Size = new System.Drawing.Size(98, 34);
            this.btnEliminarCita.TabIndex = 2;
            this.btnEliminarCita.Text = "Eliminar Cita";
            this.btnEliminarCita.UseVisualStyleBackColor = false;
            // 
            // btnIngresarCita
            // 
            this.btnIngresarCita.BackColor = System.Drawing.Color.White;
            this.btnIngresarCita.Location = new System.Drawing.Point(808, 38);
            this.btnIngresarCita.Name = "btnIngresarCita";
            this.btnIngresarCita.Size = new System.Drawing.Size(98, 34);
            this.btnIngresarCita.TabIndex = 1;
            this.btnIngresarCita.Text = "Ingresar Cita";
            this.btnIngresarCita.UseVisualStyleBackColor = false;
            this.btnIngresarCita.Click += new System.EventHandler(this.btnIngresarCita_Click);
            // 
            // btnEditarCita
            // 
            this.btnEditarCita.BackColor = System.Drawing.Color.White;
            this.btnEditarCita.Location = new System.Drawing.Point(683, 38);
            this.btnEditarCita.Name = "btnEditarCita";
            this.btnEditarCita.Size = new System.Drawing.Size(102, 34);
            this.btnEditarCita.TabIndex = 1;
            this.btnEditarCita.Text = "Editar Cita";
            this.btnEditarCita.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(203, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 25);
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
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 94);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(159, 532);
            this.flowLayoutPanel1.TabIndex = 1;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 90);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnUsuario
            // 
            this.btnUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(206)))), ((int)(((byte)(175)))));
            this.btnUsuario.Location = new System.Drawing.Point(3, 106);
            this.btnUsuario.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(154, 48);
            this.btnUsuario.TabIndex = 0;
            this.btnUsuario.Text = "Usuario";
            this.btnUsuario.UseVisualStyleBackColor = false;
            // 
            // btnCitas
            // 
            this.btnCitas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(206)))), ((int)(((byte)(175)))));
            this.btnCitas.Location = new System.Drawing.Point(3, 167);
            this.btnCitas.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.btnCitas.Name = "btnCitas";
            this.btnCitas.Size = new System.Drawing.Size(154, 48);
            this.btnCitas.TabIndex = 0;
            this.btnCitas.Text = "Citas";
            this.btnCitas.UseVisualStyleBackColor = false;
            // 
            // btnProducto
            // 
            this.btnProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(206)))), ((int)(((byte)(175)))));
            this.btnProducto.Location = new System.Drawing.Point(3, 228);
            this.btnProducto.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.btnProducto.Name = "btnProducto";
            this.btnProducto.Size = new System.Drawing.Size(154, 48);
            this.btnProducto.TabIndex = 0;
            this.btnProducto.Text = "Producto";
            this.btnProducto.UseVisualStyleBackColor = false;
            // 
            // btnHistorialMascota
            // 
            this.btnHistorialMascota.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(206)))), ((int)(((byte)(175)))));
            this.btnHistorialMascota.Location = new System.Drawing.Point(3, 289);
            this.btnHistorialMascota.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.btnHistorialMascota.Name = "btnHistorialMascota";
            this.btnHistorialMascota.Size = new System.Drawing.Size(154, 48);
            this.btnHistorialMascota.TabIndex = 0;
            this.btnHistorialMascota.Text = "Historial de la Mascota";
            this.btnHistorialMascota.UseVisualStyleBackColor = false;
            // 
            // btnRegistroEmpleados
            // 
            this.btnRegistroEmpleados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(206)))), ((int)(((byte)(175)))));
            this.btnRegistroEmpleados.Location = new System.Drawing.Point(3, 350);
            this.btnRegistroEmpleados.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.btnRegistroEmpleados.Name = "btnRegistroEmpleados";
            this.btnRegistroEmpleados.Size = new System.Drawing.Size(154, 48);
            this.btnRegistroEmpleados.TabIndex = 0;
            this.btnRegistroEmpleados.Text = "Registro de Empleados";
            this.btnRegistroEmpleados.UseVisualStyleBackColor = false;
            this.btnRegistroEmpleados.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnIngresoMascota
            // 
            this.btnIngresoMascota.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(206)))), ((int)(((byte)(175)))));
            this.btnIngresoMascota.Location = new System.Drawing.Point(3, 411);
            this.btnIngresoMascota.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.btnIngresoMascota.Name = "btnIngresoMascota";
            this.btnIngresoMascota.Size = new System.Drawing.Size(154, 48);
            this.btnIngresoMascota.TabIndex = 0;
            this.btnIngresoMascota.Text = "Ingreso de Mascotas";
            this.btnIngresoMascota.UseVisualStyleBackColor = false;
            // 
            // btnIngresoNevoEmpleado
            // 
            this.btnIngresoNevoEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(206)))), ((int)(((byte)(175)))));
            this.btnIngresoNevoEmpleado.Location = new System.Drawing.Point(3, 472);
            this.btnIngresoNevoEmpleado.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.btnIngresoNevoEmpleado.Name = "btnIngresoNevoEmpleado";
            this.btnIngresoNevoEmpleado.Size = new System.Drawing.Size(154, 48);
            this.btnIngresoNevoEmpleado.TabIndex = 0;
            this.btnIngresoNevoEmpleado.Text = "Ingreso de nuevo empleado";
            this.btnIngresoNevoEmpleado.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(159, 94);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(901, 47);
            this.panel2.TabIndex = 3;
            // 
            // MenuCitas
            // 
            this.MenuCitas.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuCitas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsEliminarCita});
            this.MenuCitas.Name = "MenuCitas";
            this.MenuCitas.Size = new System.Drawing.Size(139, 26);
            this.MenuCitas.Opening += new System.ComponentModel.CancelEventHandler(this.MenuCitas_Opening);
            // 
            // cmsEliminarCita
            // 
            this.cmsEliminarCita.Name = "cmsEliminarCita";
            this.cmsEliminarCita.Size = new System.Drawing.Size(138, 22);
            this.cmsEliminarCita.Text = "EliminarCita";
            // 
            // dgvInfoCitas
            // 
            this.dgvInfoCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfoCitas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInfoCitas.Location = new System.Drawing.Point(159, 141);
            this.dgvInfoCitas.Margin = new System.Windows.Forms.Padding(2);
            this.dgvInfoCitas.Name = "dgvInfoCitas";
            this.dgvInfoCitas.RowHeadersWidth = 51;
            this.dgvInfoCitas.RowTemplate.Height = 24;
            this.dgvInfoCitas.Size = new System.Drawing.Size(901, 485);
            this.dgvInfoCitas.TabIndex = 6;
            this.dgvInfoCitas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInfoCitas_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(233, 261);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 17);
            this.label6.TabIndex = 18;
            // 
            // dgvCitas
            // 
            this.dgvCitas.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCitas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCitas.Location = new System.Drawing.Point(159, 94);
            this.dgvCitas.Name = "dgvCitas";
            this.dgvCitas.RowHeadersWidth = 51;
            this.dgvCitas.Size = new System.Drawing.Size(901, 532);
            this.dgvCitas.TabIndex = 2;
            this.dgvCitas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // frmCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 626);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvInfoCitas);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvCitas);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
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
        public System.Windows.Forms.Button btnEditarCita;
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
    }
}