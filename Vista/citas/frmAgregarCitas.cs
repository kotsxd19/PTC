using Proyecto.Controlador.cita;
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
    public partial class frmAgregarCitas : Form
    {
        public frmAgregarCitas()
        {
            InitializeComponent();
            ControllerRegistroCitas controller = new ControllerRegistroCitas(this);
        }
    }
}
