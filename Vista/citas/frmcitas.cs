﻿using Proyecto.Controlador.cita;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto.Vista.citas
{
    public partial class frmcitas : Form
    {
        public frmcitas()
        {
            InitializeComponent();
            ControllerAgregarCita control = new ControllerAgregarCita(this);
           
        }

        //public frmcitas(int IdCitas, int IdEmpleados, int IdMascota, DateTime Fecha, TimeSpan Hora, string Descripcion)
        //{
        //    InitializeComponent();
        //    ControllerAgregarCita control = new ControllerAgregarCita(this, IdCitas, IdEmpleados, IdMascota, Fecha, Hora, Descripcion);
        //}

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmcitas_Load(object sender, EventArgs e)
        {

        }
    }
}
