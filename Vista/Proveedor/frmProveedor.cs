﻿using Proyecto.Controlador.Proveedor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto.Vista.Proveedor
{
    public partial class frmProveedor : Form
    {
        public frmProveedor()
        {
            InitializeComponent();
            ControllerProveedor uso = new ControllerProveedor(this);
        }

        private void frmProveedor_Load(object sender, EventArgs e)
        {

        }
    }
}
