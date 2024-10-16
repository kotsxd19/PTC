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

        public PrimerUsuario(frmCrearPrimerUsuario Vista)
        {
            ObjVista = Vista;
            Vista.Load += new EventHandler(CargarCombos);
            Vista.btnGuardar.Click += new EventHandler(RegistrarPrimerUsuario);
            Vista.cmbRol.Enabled = false;
        }

        void CargarCombos(object sender, EventArgs e)
        {
            //Objeto de la clase DAOAdminUsuarios
            DAOAgregarUsuario objAdmin = new DAOAgregarUsuario();
            //Declarando nuevo DataSet para que obtenga los datos del metodo LlenarCombo
            DataSet ds = objAdmin.LlenarComboBox();
            //Llenar combobox tbRole
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
                //Se crea una instancia de la clase DAOAdminUsers llamada DAOInsert
                DAOAgregarUsuario DAOInsert = new DAOAgregarUsuario();
                Incriptar commonClasses = new Incriptar();
                //Datos para creación de persona
                DAOInsert.Nombre1 = ObjVista.txtNombre.Text.Trim();
                DAOInsert.Apellido1 = ObjVista.txtApellido.Text.Trim();
                DAOInsert.FechaNacimiento1 = ObjVista.dtpFecha.Value.Date;
                DAOInsert.CorreoElectronico1 = ObjVista.txtCorreo.Text.Trim();
                //Datos para creación de usuario
                DAOInsert.Usuario1 = ObjVista.txtUsuario.Text.Trim();
                DAOInsert.Contraseña1 = commonClasses.ComputeSha256Hash(ObjVista.txtUsuario.Text.Trim() + "PU123");
                DAOInsert.Estado1 = true;
                DAOInsert.Role1 = int.Parse(ObjVista.cmbRol.SelectedValue.ToString());
                //Se invoca al método RegistrarUsuario mediante el objeto DAOInsert
                int valorRetornado = DAOInsert.RegistarEmpleados();
                //Se verifica el valor que retornó el metodo anterior y que fue almacenado en la variable valorRetornado
                if (valorRetornado == 1)
                {
                    MessageBox.Show("Los datos han sido registrados exitosamente",
                                    "Proceso completado",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    MessageBox.Show($"Usuario administrador: {ObjVista.txtUsuario.Text.Trim()}\nContraseña de usuario: {ObjVista.txtUsuario.Text.Trim()}PU123",
                                    "Credenciales de acceso",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    frmLogin login = new frmLogin();
                    login.Show();
                    ObjVista.Hide();
                }
                else
                {
                    MessageBox.Show("Los datos no pudieron ser registrados",
                                    "Proceso interrumpido",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Existen campos vacíos, complete cada uno de los apartados y verifique que la fecha seleccionada corresponde a una persona mayor de edad.",
                                    "Proceso interrumpido",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
            }
        }

    }
}
