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
<<<<<<< HEAD:Vista/citas/frmRegtistrocitas.cs

        private void frmRegtistrocitas_Load(object sender, EventArgs e)
        {

        }
=======
>>>>>>> 002252f0a195d6b8920d6776b1447baa51d8c743:Vista/citas/frmAgregarCitas.cs
    }
}
