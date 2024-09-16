using Proyecto.Controlador.IngresarUsuario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto.Vista.AgregarUsuarios
{
    public partial class frmAgregarUsuario : Form
    {

        public frmAgregarUsuario(int accion)
        {
            InitializeComponent();
            ControllerIngresarUsuario cntrol = new ControllerIngresarUsuario(this, accion);
        }

        public frmAgregarUsuario(int accion, int id, int IdRole, string Nombre, string Apellido, DateTime FechaNacimient, string CorreoEmpleado, string Usuario, string role)
        {
            InitializeComponent();
 
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmAgregarUsuario_Load(object sender, EventArgs e)
        {

        }

        private void cmbRoles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
