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
            ControllerIngresarUsuario objAgregarUser = new ControllerIngresarUsuario(this, accion);
        }

        //public frmAgregarUsuario(int accion, int id , string Nombre , string Apellido , DateTime FechaNacimient, string CorreoEmpleado , int estado , int role )
        //{
        //    InitializeComponent();
        //    ControllerIngresarUsuario objAgregarUser = new ControllerIngresarUsuario(this, accion, id, Nombre,
        //        Apellido, FechaNacimient, CorreoEmpleado, estado, role);
        //}

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

        private void LblUsuario_Click(object sender, EventArgs e)
        {

        }
    }
}
