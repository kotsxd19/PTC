namespace Proyecto.Vista.Mascota
{
    partial class frmRazas
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
            this.btnPerros = new System.Windows.Forms.Button();
            this.btnOtrasMascotas = new System.Windows.Forms.Button();
            this.btnGatos = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPerros
            // 
            this.btnPerros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPerros.FlatAppearance.BorderSize = 0;
            this.btnPerros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(112)))), ((int)(((byte)(119)))));
            this.btnPerros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerros.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerros.Image = global::Proyecto.Properties.Resources.icons8_perro_80;
            this.btnPerros.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPerros.Location = new System.Drawing.Point(12, 24);
            this.btnPerros.Name = "btnPerros";
            this.btnPerros.Size = new System.Drawing.Size(114, 102);
            this.btnPerros.TabIndex = 9;
            this.btnPerros.Text = "Perros";
            this.btnPerros.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPerros.UseVisualStyleBackColor = true;
            // 
            // btnOtrasMascotas
            // 
            this.btnOtrasMascotas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOtrasMascotas.FlatAppearance.BorderSize = 0;
            this.btnOtrasMascotas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(112)))), ((int)(((byte)(119)))));
            this.btnOtrasMascotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOtrasMascotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOtrasMascotas.Image = global::Proyecto.Properties.Resources.icons8_zoo_80;
            this.btnOtrasMascotas.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOtrasMascotas.Location = new System.Drawing.Point(20, 22);
            this.btnOtrasMascotas.Name = "btnOtrasMascotas";
            this.btnOtrasMascotas.Size = new System.Drawing.Size(114, 114);
            this.btnOtrasMascotas.TabIndex = 9;
            this.btnOtrasMascotas.Text = "Otros";
            this.btnOtrasMascotas.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnOtrasMascotas.UseVisualStyleBackColor = true;
            // 
            // btnGatos
            // 
            this.btnGatos.FlatAppearance.BorderSize = 0;
            this.btnGatos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(112)))), ((int)(((byte)(119)))));
            this.btnGatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGatos.Image = global::Proyecto.Properties.Resources.icons8_gato_80;
            this.btnGatos.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGatos.Location = new System.Drawing.Point(16, 24);
            this.btnGatos.Name = "btnGatos";
            this.btnGatos.Size = new System.Drawing.Size(114, 104);
            this.btnGatos.TabIndex = 9;
            this.btnGatos.Text = "Gatos";
            this.btnGatos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGatos.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnPerros);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(142, 167);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnOtrasMascotas);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(278, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(146, 167);
            this.panel2.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnGatos);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(142, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(136, 167);
            this.panel3.TabIndex = 12;
            // 
            // frmRazas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(251)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(424, 167);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmRazas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRazas";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btnGatos;
        public System.Windows.Forms.Button btnOtrasMascotas;
        public System.Windows.Forms.Button btnPerros;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}