﻿using Proyecto.Controlador.Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto.Vista.Login
{
    public partial class frmRecuperacioneDeContra : Form
    {
        public frmRecuperacioneDeContra()
        {
            InitializeComponent();
            ModosDeRecuperarContraseña siguiente = new ModosDeRecuperarContraseña(this);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void frmRecuperacioneDeContra_Load(object sender, EventArgs e)
        {

        }
    }
}
