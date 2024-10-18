using Proyecto.Controlador.Validar;
using Proyecto.Modelo.DAO;
using Proyecto.Vista.Login;
using Proyecto.Vista.PrimerUso;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto.Controlador.PrimerUso
{
    internal class PrimerUsuario
    {
        frmCrearPrimerUsuario ObjVista;

        public PrimerUsuario(frmCrearPrimerUsuario vista)
        {
            ObjVista = vista;
            vista.Load += new EventHandler(CargarCombos);
            vista.btnGuardar.Click += new EventHandler(RegistrarPrimerUsuario);
            vista.cmbRol.Enabled = false;
        }

        void CargarCombos(object sender, EventArgs e)
        {
            // Objeto de la clase DAOAgregarUsuario
            DAOAgregarUsuario objAdmin = new DAOAgregarUsuario();

            // Llenar combobox de roles
            DataSet ds = objAdmin.LlenarComboBox();
            ObjVista.cmbRol.DataSource = ds.Tables["Roles"];
            ObjVista.cmbRol.ValueMember = "IdRoles";
            ObjVista.cmbRol.DisplayMember = "Roles";
        }

        void RegistrarPrimerUsuario(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(ObjVista.txtNombre.Text.Trim()) ||
                string.IsNullOrEmpty(ObjVista.txtApellido.Text.Trim()) ||
                string.IsNullOrEmpty(ObjVista.txtContra.Text.Trim()) ||
                string.IsNullOrEmpty(ObjVista.txtCorreo.Text.Trim()) ||
                string.IsNullOrEmpty(ObjVista.txtUsuario.Text.Trim())))
            {
                // Crear instancia de DAOAgregarUsuario para insertar datos
                DAOAgregarUsuario DAOInsert = new DAOAgregarUsuario();
                Incriptar commonClasses = new Incriptar();

                // Datos de la persona
                DAOInsert.Nombre1 = ObjVista.txtNombre.Text.Trim();
                DAOInsert.Apellido1 = ObjVista.txtApellido.Text.Trim();
                DAOInsert.FechaNacimiento1 = ObjVista.dtpFecha.Value.Date;
                DAOInsert.CorreoElectronico1 = ObjVista.txtCorreo.Text.Trim();

                // Datos de usuario
                DAOInsert.Usuario1 = ObjVista.txtUsuario.Text.Trim();
                // Cifrar contraseña
                DAOInsert.Contraseña1 = commonClasses.ComputeSha256Hash(ObjVista.txtUsuario.Text.Trim() + ObjVista.txtContra.Text.Trim());
                DAOInsert.Estado1 = true;
                DAOInsert.Role1 = int.Parse(ObjVista.cmbRol.SelectedValue.ToString());

                // Registrar usuario
                int valorRetornado = DAOInsert.RegistarEmpleados();

                if (valorRetornado == 1)
                {
                    MessageBox.Show("Datos registrados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmLogin login = new frmLogin();
                    login.Show();
                    ObjVista.Hide();
                }
                else
                {
                    MessageBox.Show("Error al registrar los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Complete todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }


}
