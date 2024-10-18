using Proyecto.Controlador.Servidor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto.Vista.Servidor
{
    public partial class frmConfrimarContraseña : Form
    {
        public frmConfrimarContraseña()
        {
            InitializeComponent();
            ControllerConfrimarContraseña contra = new ControllerConfrimarContraseña(this);
        }

        private void frmConfrimarContraseña_Load(object sender, EventArgs e)
        {

        }
    }
}
