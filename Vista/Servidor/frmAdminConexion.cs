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
    public partial class frmAdminConexion : Form
    {
        public frmAdminConexion()
        {
            InitializeComponent();
            ControllerConexionAdmin conexion = new ControllerConexionAdmin(this);
        }

        private void frmAdminConexion_Load(object sender, EventArgs e)
        {

        }
    }
}
