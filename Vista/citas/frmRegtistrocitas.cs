using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto.Controlador.cita;

namespace Proyecto.Vista.citas
{
    public partial class frmRegtistrocitas : Form
    {
        public frmRegtistrocitas()
        {
            InitializeComponent();
            ControllerRegistroCitas registro = new ControllerRegistroCitas(this);
        }

        private void frmRegtistrocitas_Load(object sender, EventArgs e)
        {

        }

    }
}
