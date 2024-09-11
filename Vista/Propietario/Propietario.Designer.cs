using System;
using System.Windows.Forms;

namespace Proyecto.Vista.Propietario
{
    partial class Propietario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Propietario));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btmdelete = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnTelefono = new System.Windows.Forms.Label();
            this.btnDui = new System.Windows.Forms.Label();
            this.BTNApellido = new System.Windows.Forms.Label();
            this.BTNNombre = new System.Windows.Forms.Label();
            this.txtbTelefono = new System.Windows.Forms.TextBox();
            this.txtbApellido = new System.Windows.Forms.TextBox();
            this.txtbDUI = new System.Windows.Forms.TextBox();
            this.txtbNombre = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(220)))), ((int)(((byte)(186)))));
            this.panel1.Controls.Add(this.btmdelete);
            this.panel1.Controls.Add(this.btnMostrar);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.btnActualizar);
            this.panel1.Controls.Add(this.btnIngresar);
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.btnTelefono);
            this.panel1.Controls.Add(this.btnDui);
            this.panel1.Controls.Add(this.BTNApellido);
            this.panel1.Controls.Add(this.BTNNombre);
            this.panel1.Controls.Add(this.txtbTelefono);
            this.panel1.Controls.Add(this.txtbApellido);
            this.panel1.Controls.Add(this.txtbDUI);
            this.panel1.Controls.Add(this.txtbNombre);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(-23, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(948, 607);
            this.panel1.TabIndex = 4;
            // 
            // btmdelete
            // 
            this.btmdelete.Location = new System.Drawing.Point(658, 423);
            this.btmdelete.Name = "btmdelete";
            this.btmdelete.Size = new System.Drawing.Size(182, 43);
            this.btmdelete.TabIndex = 48;
            this.btmdelete.Text = "Eliminar";
            this.btmdelete.UseVisualStyleBackColor = true;
            this.btmdelete.Click += new System.EventHandler(this.btmdelete_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(658, 376);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(182, 41);
            this.btnMostrar.TabIndex = 46;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(102, 247);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(446, 327);
            this.dataGridView1.TabIndex = 45;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(658, 539);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(182, 35);
            this.btnActualizar.TabIndex = 44;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(658, 484);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(182, 38);
            this.btnIngresar.TabIndex = 43;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(0, 0);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 47;
            // 
            // btnTelefono
            // 
            this.btnTelefono.AutoSize = true;
            this.btnTelefono.Location = new System.Drawing.Point(422, 176);
            this.btnTelefono.Name = "btnTelefono";
            this.btnTelefono.Size = new System.Drawing.Size(106, 13);
            this.btnTelefono.TabIndex = 41;
            this.btnTelefono.Text = "Número de Telélfono";
            // 
            // btnDui
            // 
            this.btnDui.AutoSize = true;
            this.btnDui.Location = new System.Drawing.Point(212, 176);
            this.btnDui.Name = "btnDui";
            this.btnDui.Size = new System.Drawing.Size(26, 13);
            this.btnDui.TabIndex = 40;
            this.btnDui.Text = "DUI";
            // 
            // BTNApellido
            // 
            this.BTNApellido.AutoSize = true;
            this.BTNApellido.Location = new System.Drawing.Point(212, 116);
            this.BTNApellido.Name = "BTNApellido";
            this.BTNApellido.Size = new System.Drawing.Size(44, 13);
            this.BTNApellido.TabIndex = 39;
            this.BTNApellido.Text = "Apellido";
            // 
            // BTNNombre
            // 
            this.BTNNombre.AutoSize = true;
            this.BTNNombre.Location = new System.Drawing.Point(212, 70);
            this.BTNNombre.Name = "BTNNombre";
            this.BTNNombre.Size = new System.Drawing.Size(44, 13);
            this.BTNNombre.TabIndex = 38;
            this.BTNNombre.Text = "Nombre";
            // 
            // txtbTelefono
            // 
            this.txtbTelefono.ForeColor = System.Drawing.Color.Black;
            this.txtbTelefono.Location = new System.Drawing.Point(425, 192);
            this.txtbTelefono.Name = "txtbTelefono";
            this.txtbTelefono.Size = new System.Drawing.Size(282, 20);
            this.txtbTelefono.TabIndex = 37;
            this.txtbTelefono.TextChanged += new System.EventHandler(this.txtbTelefono_TextChanged);
            // 
            // txtbApellido
            // 
            this.txtbApellido.ForeColor = System.Drawing.Color.Black;
            this.txtbApellido.Location = new System.Drawing.Point(215, 132);
            this.txtbApellido.Name = "txtbApellido";
            this.txtbApellido.Size = new System.Drawing.Size(492, 20);
            this.txtbApellido.TabIndex = 36;
            this.txtbApellido.TextChanged += new System.EventHandler(this.txtbApellido_TextChanged);
            // 
            // txtbDUI
            // 
            this.txtbDUI.ForeColor = System.Drawing.Color.Black;
            this.txtbDUI.Location = new System.Drawing.Point(213, 192);
            this.txtbDUI.Name = "txtbDUI";
            this.txtbDUI.Size = new System.Drawing.Size(151, 20);
            this.txtbDUI.TabIndex = 35;
            this.txtbDUI.TextChanged += new System.EventHandler(this.txtbDUI_TextChanged);
            // 
            // txtbNombre
            // 
            this.txtbNombre.ForeColor = System.Drawing.Color.Black;
            this.txtbNombre.Location = new System.Drawing.Point(215, 86);
            this.txtbNombre.Name = "txtbNombre";
            this.txtbNombre.Size = new System.Drawing.Size(492, 20);
            this.txtbNombre.TabIndex = 34;
            this.txtbNombre.TextChanged += new System.EventHandler(this.txtbNombre_TextChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(724, 70);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(203, 251);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 32;
            this.pictureBox3.TabStop = false;

            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(364, 253);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(0, 0);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Propietario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 620);
            this.Controls.Add(this.panel1);
            this.Name = "Propietario";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        private void txtbApellido_TextChanged(object sender, EventArgs e)
        {
            // Obtener el valor del texto ingresado en el TextBox
            string apellido = txtbApellido.Text;

           
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btmdelete;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnIngresar;
        public System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label btnTelefono;
        private System.Windows.Forms.Label btnDui;
        private System.Windows.Forms.Label BTNApellido;
        private System.Windows.Forms.Label BTNNombre;
        private System.Windows.Forms.TextBox txtbTelefono;
        private System.Windows.Forms.TextBox txtbApellido;
        private System.Windows.Forms.TextBox txtbDUI;
        private System.Windows.Forms.TextBox txtbNombre;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button1;
    }
}