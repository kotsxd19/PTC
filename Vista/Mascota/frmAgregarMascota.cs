﻿using Proyecto.Controlador.Mascota;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto.Vista.Mascota
{
    public partial class frmAgregarMascota : Form
    {
        public frmAgregarMascota()
        {
            InitializeComponent();
           ControllerAgregarMascota mascota = new ControllerAgregarMascota(this);
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmAgregarMascota_Load(object sender, EventArgs e)
        {

        }

        private void dgvDueño_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
