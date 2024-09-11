using Proyecto.Controlador.Validar;
using Proyecto.Modelo.DAO;
using Proyecto.Vista.AgregarUsuarios;
using Proyecto.Vista.Login;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto.Controlador.IngresarUsuario
{
    internal class ControllerIngresarUsuario
    {
        frmAgregarUsuario ObjAgregarUsuario;
        private int accion;
        private string role;

        public ControllerIngresarUsuario(frmAgregarUsuario Vista)
        {
            //Acciones iniciales
            ObjAgregarUsuario = Vista;
            this.accion = accion;
            //Métodos iniciales: estos metodos se ejecutan cuando el formulario está cargando
            verificarAccion();
            ObjAgregarUsuario.Load += new EventHandler(CargaInicial);

            //Métodos que se ejecutan al ocurrir eventos
            ObjAgregarUsuario.btnIngresar.Click += new EventHandler(NuevoRegistro);
        }

        public ControllerIngresarUsuario(frmAgregarUsuario Vista, int p_accion, int id, int IdRole, string Nombre, string Apellido, DateTime FechaNacimient, string CorreoEmpleado, string Usuario, string role)
        {
            //Acciones iniciales
            ObjAgregarUsuario = Vista;
            //Se guarda en la variable acción en vaor
            this.accion = p_accion;
            this.role = role;
            //Métodos iniciales: estos metodos se ejecutan cuando el formulario está cargando
            ObjAgregarUsuario.Load += new EventHandler(CargaInicial);
            verificarAccion();
            CambiarValores(id,IdRole, Nombre, Apellido, FechaNacimient, CorreoEmpleado, Usuario);
            //Métodos que se ejecutan al ocurrir eventos
            ObjAgregarUsuario.btnActualizar.Click += new EventHandler(ActualizarDatos);
        }

        public void CargaInicial(object sender, EventArgs e)
        {
            //Objeto de la clase DAOAdminUsuarios
            DAOAgregarUsuario objAdmin = new DAOAgregarUsuario();
            //Declarando nuevo DataSet para que obtenga los datos del metodo LlenarCombo
            DataSet ds = objAdmin.LlenarComboBox();
            ObjAgregarUsuario.cmbRoles.DataSource = ds.Tables["Roles"];
            ObjAgregarUsuario.cmbRoles.ValueMember = "IdRoles";
            ObjAgregarUsuario.cmbRoles.DisplayMember = "Roles";
            if (accion == 2)
            {
                ObjAgregarUsuario.cmbRoles.Text = role;
            }
        }

        public void verificarAccion()
        {

            if (accion == 1)
            {
                ObjAgregarUsuario.btnIngresar.Enabled = true;
                ObjAgregarUsuario.btnActualizar.Enabled = false;
                ObjAgregarUsuario.btnCancelar.Enabled = false;
            }
            else if (accion == 2)
            {
                ObjAgregarUsuario.btnIngresar.Enabled = false;
                ObjAgregarUsuario.btnActualizar.Enabled = true;
                ObjAgregarUsuario.txtUsuario.Enabled = false;
            }
            else if (accion == 3)
            {
                ObjAgregarUsuario.btnIngresar.Enabled = false;
                ObjAgregarUsuario.btnActualizar.Enabled = false;
                ObjAgregarUsuario.txtNombre.Enabled = false;
                ObjAgregarUsuario.txtApellido.Enabled = false;
                ObjAgregarUsuario.txtCorreo.Enabled = false;
                ObjAgregarUsuario.dtpNacimiento.Enabled = false;
                ObjAgregarUsuario.txtUsuario.Enabled = false;
                ObjAgregarUsuario.cmbRoles.Enabled = false;
            }
        }

        public void NuevoRegistro(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(ObjAgregarUsuario.txtNombre.Text.Trim()) ||
                string.IsNullOrEmpty(ObjAgregarUsuario.txtApellido.Text.Trim()) ||
                string.IsNullOrEmpty(ObjAgregarUsuario.txtCorreo.Text.Trim()) ||
                string.IsNullOrEmpty(ObjAgregarUsuario.txtUsuario.Text.Trim())))
            {
                //Se crea una instancia de la clase DAOAdminUsers llamada DAOInsert
                DAOAgregarUsuario DAOInsert = new DAOAgregarUsuario();
                Incriptar commonClasses = new Incriptar();
                //Datos para creación de persona
                DAOInsert.Nombre1 = ObjAgregarUsuario.txtNombre.Text.Trim();
                DAOInsert.Apellido1 = ObjAgregarUsuario.txtApellido.Text.Trim();
                DAOInsert.FechaNacimiento1 = ObjAgregarUsuario.dtpNacimiento.Value.Date;
                //Datos para creación de usuario
                DAOInsert.Usuario1 = ObjAgregarUsuario.txtUsuario.Text.Trim();
                DAOInsert.Contraseña1 = commonClasses.ComputeSha256Hash(ObjAgregarUsuario.txtUsuario.Text.Trim() + "PU123");
                DAOInsert.Role1 = (ObjAgregarUsuario.cmbRoles.SelectedValue.ToString());
                //Se invoca al método RegistrarUsuario mediante el objeto DAOInsert
                int valorRetornado = DAOInsert.RegistarEmpleados();
                //Se verifica el valor que retornó el metodo anterior y que fue almacenado en la variable valorRetornado
                if (valorRetornado == 1)
                {
                    //SavePhoto();       
                    MessageBox.Show("Los datos ingresados han sido registrados exitosamente",
                                    "Proceso completado",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Los datos que ingreso no pudieron ser registrados correctamente",
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

        public void ActualizarDatos(object sender, EventArgs e)
        {
            DAOAgregarUsuario daoUpdate = new DAOAgregarUsuario();
            daoUpdate.IdEmpleado1 = int.Parse(ObjAgregarUsuario.txtId.Text.Trim());
            daoUpdate.Nombre1 = ObjAgregarUsuario.txtNombre.Text.Trim();
            daoUpdate.Apellido1 = ObjAgregarUsuario.txtApellido.Text.Trim();
            daoUpdate.FechaNacimiento1 = ObjAgregarUsuario.dtpNacimiento.Value;
            daoUpdate.CorreoElectronico1 = ObjAgregarUsuario.txtCorreo.Text.Trim();
            daoUpdate.Role1 = (string)ObjAgregarUsuario.cmbRoles.SelectedValue;
            daoUpdate.Usuario1 = ObjAgregarUsuario.txtUsuario.Text.Trim();
            int valorRetornado = daoUpdate.ActualizarEmpleados();
            if (valorRetornado == 2)
            {
                MessageBox.Show("Los datos han sido actualizado exitosamente",
                                "Proceso completado",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else if (valorRetornado == 1)
            {
                MessageBox.Show("Los datos no pudieron ser actualizados completamente",
                                "Proceso interrumpido",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Los datos no pudieron ser actualizados debido a un error inesperado",
                                "Proceso interrumpido",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        public void CambiarValores(int id,int IdRole, string Nombre, string Apellido, DateTime FechaNacimient, string CorreoEmpleado,string Usuario)
        {
            try
            {
                ObjAgregarUsuario.txtId.Text = id.ToString();
                ObjAgregarUsuario.cmbRoles.Text = IdRole.ToString();
                ObjAgregarUsuario.txtNombre.Text = Nombre;
                ObjAgregarUsuario.txtApellido.Text = Apellido;
                ObjAgregarUsuario.dtpNacimiento.Value = FechaNacimient;
                ObjAgregarUsuario.txtCorreo.Text = CorreoEmpleado;
                ObjAgregarUsuario.txtUsuario.Text = Usuario;

                //Carga sobre Label
                ObjAgregarUsuario.LblNombre.Text = Nombre;
                ObjAgregarUsuario.LblApellido.Text = Apellido;
                ObjAgregarUsuario.LblUsuario.Text = Usuario;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }
    }
}
