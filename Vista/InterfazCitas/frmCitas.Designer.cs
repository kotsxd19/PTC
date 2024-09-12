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
            this.txtIdEmpleados = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdMascota = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.dtpHora = new System.Windows.Forms.DateTimePicker();
            this.dgvCitas = new System.Windows.Forms.DataGridView();
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
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1413, 116);
            this.panel1.TabIndex = 0;
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
            // btnEditarCita
            // 
            this.btnEditarCita.BackColor = System.Drawing.Color.White;
            this.btnEditarCita.Location = new System.Drawing.Point(911, 47);
            this.btnEditarCita.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditarCita.Name = "btnEditarCita";
            this.btnEditarCita.Size = new System.Drawing.Size(136, 42);
            this.btnEditarCita.TabIndex = 1;
            this.btnEditarCita.Text = "Editar Cita";
            this.btnEditarCita.UseVisualStyleBackColor = false;
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
            this.dgvInfoCitas.Location = new System.Drawing.Point(333, 472);
            this.dgvInfoCitas.Name = "dgvInfoCitas";
            this.dgvInfoCitas.RowHeadersWidth = 51;
            this.dgvInfoCitas.RowTemplate.Height = 24;
            this.dgvInfoCitas.Size = new System.Drawing.Size(951, 188);
            this.dgvInfoCitas.TabIndex = 6;
            // 
            // txtIdEmpleados
            // 
            this.txtIdEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdEmpleados.Location = new System.Drawing.Point(580, 208);
            this.txtIdEmpleados.Name = "txtIdEmpleados";
            this.txtIdEmpleados.Size = new System.Drawing.Size(212, 27);
            this.txtIdEmpleados.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(342, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ingresé el ID del empleado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(342, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ingresé el ID de la mascota:";
            // 
            // txtIdMascota
            // 
            this.txtIdMascota.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdMascota.Location = new System.Drawing.Point(580, 262);
            this.txtIdMascota.Name = "txtIdMascota";
            this.txtIdMascota.Size = new System.Drawing.Size(212, 27);
            this.txtIdMascota.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(852, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Ingresé la fecha:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(852, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Ingresé la hora:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(1019, 209);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 22);
            this.dtpFecha.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(342, 322);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Ingresé la descripción:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(539, 319);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(656, 99);
            this.txtDescripcion.TabIndex = 17;
            // 
            // dtpHora
            // 
            this.dtpHora.Location = new System.Drawing.Point(1019, 269);
            this.dtpHora.Name = "dtpHora";
            this.dtpHora.Size = new System.Drawing.Size(200, 22);
            this.dtpHora.TabIndex = 19;
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
            // frmCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1413, 770);
            this.Controls.Add(this.dtpHora);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIdMascota);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdEmpleados);
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
        public System.Windows.Forms.Button btnEditarCita;
        public System.Windows.Forms.Button btnUsuario;
        public System.Windows.Forms.Button btnIngresarCita;
        public System.Windows.Forms.Button btnHistorialMascota;
        public System.Windows.Forms.Button btnProducto;
        public System.Windows.Forms.Button btnCitas;
        public System.Windows.Forms.Button btnIngresoNevoEmpleado;
        public System.Windows.Forms.Button btnIngresoMascota;
        public System.Windows.Forms.Button btnRegistroEmpleados;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtIdEmpleados;
        public System.Windows.Forms.TextBox txtIdMascota;
        public System.Windows.Forms.DateTimePicker dtpFecha;
        public System.Windows.Forms.TextBox txtDescripcion;
        public System.Windows.Forms.DateTimePicker dtpHora;
        public System.Windows.Forms.DataGridView dgvCitas;
        public System.Windows.Forms.Button btnEliminarCita;
        public System.Windows.Forms.DataGridView dgvInfoCitas;
    }
}