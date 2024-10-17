using Proyecto.Controlador.Propietario;
using Proyecto.Controlador.Proveedor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto.Vista.Dueño
{
    public partial class frmDueño : Form
    {
        public frmDueño()
        {
            InitializeComponent();
            ControllerPropietarios vistaPropietario = new ControllerPropietarios(this);
        }

        private void frmDueño_Load(object sender, EventArgs e)
        {

        }
    }
}
