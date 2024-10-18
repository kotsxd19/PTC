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

        // Constructor que inicializa el controlador para el formulario de agregar usuario, con la acción y eventos asociados.
        public ControllerIngresarUsuario(frmAgregarUsuario Vista, int accion)
        {
            ObjAgregarUsuario = Vista;
            this.accion = accion;
            this.role = role;

            verificarAccion(); // Verifica la acción para habilitar o deshabilitar controles según la acción
            ObjAgregarUsuario.Load += new EventHandler(CargaInicial); // Asocia el evento Load del formulario al método CargaInicial
            ObjAgregarUsuario.btnIngresar.Click += new EventHandler(NuevoRegistro); // Asocia el evento Click del botón Ingresar al método NuevoRegistro
        }

        // Constructor sobrecargado para inicializar el controlador con datos adicionales para la edición de usuario.
        public ControllerIngresarUsuario(frmAgregarUsuario Vista, int p_accion, int id, string Nombre, string Apellido, DateTime FechaNacimient, string CorreoEmpleado, string Usuario, string role)
        {
            ObjAgregarUsuario = Vista;
            this.accion = p_accion;
            this.role = role;
            ObjAgregarUsuario.Load += new EventHandler(CargaInicial); // Asocia el evento Load del formulario al método CargaInicial
            verificarAccion(); // Verifica la acción para habilitar o deshabilitar controles según la acción
            CambiarValores(id, Nombre, Apellido, FechaNacimient, CorreoEmpleado, Usuario); // Carga los datos del usuario en el formulario
            
            ObjAgregarUsuario.btnActualizar.Click += new EventHandler(ActualizarDatos); // Asocia el evento Click del botón Actualizar al método ActualizarDatos
        }

        // Método para cargar la información inicial en el formulario cuando se carga.
        public void CargaInicial(object sender, EventArgs e)
        {
            DAOAgregarUsuario objAdmin = new DAOAgregarUsuario(); // Crea una instancia del DAO para obtener datos
            DataSet ds = objAdmin.LlenarComboBox(); // Obtiene los datos para llenar el ComboBox de roles
            ObjAgregarUsuario.cmbRoles.DataSource = ds.Tables["Roles"]; // Asocia el DataSource del ComboBox
            ObjAgregarUsuario.cmbRoles.ValueMember = "IdRoles"; // Establece el valor que se utilizará
            ObjAgregarUsuario.cmbRoles.DisplayMember = "Roles"; // Establece el texto que se mostrará en el ComboBox

            if (accion == 2)
            {
                ObjAgregarUsuario.cmbRoles.Text = role; // Establece el texto del ComboBox para la acción de edición
            }

            ObjAgregarUsuario.cmbEstado.Enabled = true;

            ObjAgregarUsuario.cmbEstado.Items.Clear();

            ObjAgregarUsuario.cmbEstado.Items.Add(new KeyValuePair<string, int>("Activo", 1));
            ObjAgregarUsuario.cmbEstado.Items.Add(new KeyValuePair<string, int>("Inactivo", 2));

            ObjAgregarUsuario.cmbEstado.DisplayMember = "Key";

            ObjAgregarUsuario.cmbEstado.ValueMember = "Value";

            ObjAgregarUsuario.cmbEstado.SelectedIndex = 0; // Esto selecciona "Activo" por defecto

            // Evita acceder al SelectedItem inmediatamente después de la carga
            ObjAgregarUsuario.cmbEstado.SelectedIndexChanged += (s, ev) =>
            {
                if (ObjAgregarUsuario.cmbEstado.SelectedItem != null)
                {
                    int estadoSeleccionado = ((KeyValuePair<String, int>)ObjAgregarUsuario.cmbEstado.SelectedItem).Value;
                }
            };
        }

        //public void Estado(object sneder, EventArgs e)
        //{
        //    //DAOAgregarUsuario objEstado = new DAOAgregarUsuario();
        //    // DataSet ds = objEstado.LlenarComboBox()

            


        //}

        // Método para configurar la visibilidad y habilitación de los controles según la acción especificada.
        public void verificarAccion()
        {
            if (accion == 1) // Acción de agregar nuevo usuario
            {
                ObjAgregarUsuario.btnIngresar.Enabled = true;
                ObjAgregarUsuario.btnActualizar.Enabled = false;
                ObjAgregarUsuario.btnCancelar.Enabled = false;
            }
            else if (accion == 2) // Acción de editar usuario
            {
                ObjAgregarUsuario.btnIngresar.Enabled = false;
                ObjAgregarUsuario.btnActualizar.Enabled = true;
                ObjAgregarUsuario.txtUsuario.Enabled = false;
                ObjAgregarUsuario.txtContra.Enabled = false;    // Deshabilita el campo de usuario para evitar cambios
            }
            else if (accion == 3) // Acción de solo lectura
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

   

        // Método para registrar un nuevo usuario en la base de datos.
        public void NuevoRegistro(object sender, EventArgs e)
            {
            try
            {
                if (!(string.IsNullOrEmpty(ObjAgregarUsuario.txtNombre.Text.Trim()) ||
                string.IsNullOrEmpty(ObjAgregarUsuario.txtApellido.Text.Trim()) ||
                string.IsNullOrEmpty(ObjAgregarUsuario.txtCorreo.Text.Trim()) ||
                string.IsNullOrEmpty(ObjAgregarUsuario.txtUsuario.Text.Trim())))
                {

                    DAOAgregarUsuario DAOInsert = new DAOAgregarUsuario();
                    Incriptar commonClasses = new Incriptar();
                    DAOInsert.Nombre1 = ObjAgregarUsuario.txtNombre.Text.Trim();
                    DAOInsert.Apellido1 = ObjAgregarUsuario.txtApellido.Text.Trim();
                    DAOInsert.FechaNacimiento1 = ObjAgregarUsuario.dtpNacimiento.Value.Date;
                    DAOInsert.CorreoElectronico1 = ObjAgregarUsuario.txtCorreo.Text.Trim();

                    DAOInsert.Usuario1 = ObjAgregarUsuario.txtUsuario.Text.Trim();
                    DAOInsert.Contraseña1 = commonClasses.CrearHash(ObjAgregarUsuario.txtContra.Text.Trim());
                    DAOInsert.Role1 = int.Parse(ObjAgregarUsuario.cmbRoles.SelectedValue.ToString());

                    int estadoSeleccionado = ((KeyValuePair<string, int>)ObjAgregarUsuario.cmbEstado.SelectedItem).Value;
                    DAOInsert.Estado1 = estadoSeleccionado == 1;


                    int valorRetornado = DAOInsert.RegistarEmpleados(); // Registra el nuevo usuario
                    if (valorRetornado == 1)
                    {
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
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Método para actualizar los datos de un usuario existente en la base de datos.
        public void ActualizarDatos(object sender, EventArgs e)
        {
            DAOAgregarUsuario daoUpdate = new DAOAgregarUsuario();
                daoUpdate.IdEmpleado1 = int.Parse(ObjAgregarUsuario.txtId.Text.Trim());
                daoUpdate.Nombre1 = ObjAgregarUsuario.txtNombre.Text.Trim();
                daoUpdate.Apellido1 = ObjAgregarUsuario.txtApellido.Text.Trim();
                daoUpdate.FechaNacimiento1 = ObjAgregarUsuario.dtpNacimiento.Value;
                daoUpdate.CorreoElectronico1 = ObjAgregarUsuario.txtCorreo.Text.Trim();
                daoUpdate.Role1 = (int)ObjAgregarUsuario.cmbRoles.SelectedValue;
                daoUpdate.Usuario1 = ObjAgregarUsuario.txtUsuario.Text.Trim();
                int valorRetornado = daoUpdate.ActualizarEmpleados(); // Actualiza el usuario
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

        

        // Método para llenar los campos del formulario con los datos del usuario que se está editando.
        public void CambiarValores(int id, string Nombre, string Apellido, DateTime FechaNacimient, string CorreoEmpleado, string Usuario)
        {
            try
            {
                ObjAgregarUsuario.txtId.Text = id.ToString();
                ObjAgregarUsuario.txtNombre.Text = Nombre;
                ObjAgregarUsuario.txtApellido.Text = Apellido;
                ObjAgregarUsuario.dtpNacimiento.Value = FechaNacimient;
                ObjAgregarUsuario.txtCorreo.Text = CorreoEmpleado;
                ObjAgregarUsuario.txtUsuario.Text = Usuario;

                // Actualiza las etiquetas con el nombre, apellido y usuario del empleado
                ObjAgregarUsuario.LblNombre.Text = Nombre;
                ObjAgregarUsuario.LblApellido.Text = Apellido;
                ObjAgregarUsuario.LblUsuario.Text = Usuario;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}"); // Muestra mensaje de error en caso de excepción
            }
        }

    }
}
