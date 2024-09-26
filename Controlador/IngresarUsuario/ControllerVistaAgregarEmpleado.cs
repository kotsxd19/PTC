using Proyecto.Modelo.DAO;
using Proyecto.Vista.AgregarUsuarios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto.Controlador.Validar;

namespace Proyecto.Controlador.IngresarUsuario
{
    internal class ControllerVistaAgregarEmpleado
    {

        frmRegistroUsuario ObjAdminUser;
        // Constructor del controlador que inicializa los eventos del formulario de registro de usuario.
        public ControllerVistaAgregarEmpleado(frmRegistroUsuario Vista)
        {
            ObjAdminUser = Vista; // Asocia el formulario actual con el controlador
            ObjAdminUser.Load += new EventHandler(CargarDatos); // Asocia el evento Load del formulario al método CargarDatos
            ObjAdminUser.btnNuevoEmpleado.Click += new EventHandler(nuevoUsuario); // Asocia el evento Click del botón Nuevo Empleado al método nuevoUsuario
            //ObjAdminUser.btnActualizar.Click += new EventHandler(AcualizarEmpleado); // Asocia el evento Click del botón Actualizar al método ActualizarEmpleado
            ObjAdminUser.btnElminarEmpleado.Click += new EventHandler(DeleteUser); // Asocia el evento Click del menú contextual Eliminar al método DeleteUser
            ObjAdminUser.cmsFicha.Click += new EventHandler(VerFicha); // Asocia el evento Click del menú contextual Ficha al método VerFicha
            ObjAdminUser.btnBuscar.Click += new EventHandler(BuscarPeronasControllerEvent); // Asocia el evento Click del botón Buscar al método BuscarPeronasControllerEvent
        }

        // Método que se llama cuando se carga el formulario; refresca los datos mostrados.
        public void CargarDatos(object sender, EventArgs e)
        {
            RefrescarData(); // Llama al método para actualizar los datos en el DataGridView
        }

        // Método que refresca los datos en el DataGridView.
        public void RefrescarData()
        {
            try
            {
                DAOAgregarUsuario objAdmin = new DAOAgregarUsuario(); // Crea una instancia del DAO para obtener datos
                DataSet ds = new DataSet();
                ds = objAdmin.ObtenerPersonas(); // Obtiene la lista de personas desde la base de datos

                ObjAdminUser.dgvEmpleados.DataSource = ds.Tables["RegistroEmpleado"]; // Asocia el DataSource del DataGridView con los datos obtenidos
            }
            catch (Exception)
            {

                MessageBox.Show("Error al cargar los datos.", "Error de proceso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

  

        }
        // Método que abre el formulario para agregar un nuevo usuario.
        private void nuevoUsuario(object sender, EventArgs e)
        {
            frmAgregarUsuario openForm = new frmAgregarUsuario(1); // Crea una nueva instancia del formulario para agregar usuario
            openForm.ShowDialog(); // Muestra el formulario como un diálogo modal
            RefrescarData(); // Refresca los datos en el DataGridView después de cerrar el formulario
        }

        // Método que abre el formulario para actualizar los datos del usuario seleccionado.
        private void AcualizarEmpleado(object sender, EventArgs e)
        {
            int pos = ObjAdminUser.dgvEmpleados.CurrentRow.Index; // Obtiene la posición de la fila seleccionada en el DataGridView

            // Crea una nueva instancia del formulario para editar usuario con la acción de actualización
            frmAgregarUsuario openForm = new frmAgregarUsuario(2);

            // Enviar los datos de la fila seleccionada al formulario de edición
            ObjAdminUser.dgvEmpleados[1, pos].Value.ToString();
            ObjAdminUser.dgvEmpleados[2, pos].Value.ToString();
            DateTime.Parse(ObjAdminUser.dgvEmpleados[3, pos].Value.ToString());
            ObjAdminUser.dgvEmpleados[4, pos].Value.ToString();

            openForm.ShowDialog(); // Muestra el formulario como un diálogo modal
            RefrescarData(); // Refresca los datos en el DataGridView después de cerrar el formulario
        }

        // Método que elimina al usuario seleccionado.
        private void DeleteUser(object sender, EventArgs e)
        {
            int pos = ObjAdminUser.dgvEmpleados.CurrentRow.Index; // Obtiene la posición de la fila seleccionada
            string userSelected = ObjAdminUser.dgvEmpleados[0, pos].Value.ToString(); // Obtiene el nombre de usuario seleccionado

            // Muestra un mensaje de confirmación antes de eliminar
            if (!(userSelected.Equals(Acceso.Usuario) || userSelected.Equals("Usuario")))
            {
                if (MessageBox.Show($"• Se eliminará la información de la persona, sin embargo, el usuario asociado quedará inactivo.\n\n• ¿Esta seguro que desea elimar a: {ObjAdminUser.dgvEmpleados[0, pos].Value.ToString()} , considere que dicha acción no se podrá revertir. \n\n• Si desea mantener la información utilice la opción de deshabilitar usuario.", "Confirmar acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DAOAgregarUsuario daoDel = new DAOAgregarUsuario(); // Crea una instancia del DAO para eliminar datos
                    
                    daoDel.Usuario1 = ObjAdminUser.dgvEmpleados[1, pos].Value.ToString(); // Establece el nombre de usuario a eliminar

                    int valorRetornado = daoDel.EliminarEmplado(); // Llama al método para eliminar el usuario
                    if (valorRetornado == 2)
                    {
                        MessageBox.Show("Registro eliminado", "Acción completada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefrescarData(); // Refresca los datos en el DataGridView después de eliminar el usuario
                    }
                    else
                    {
                        MessageBox.Show("Registro no pudo ser eliminado, verifique que el registro no tenga datos asociados.", "Acción interrumpida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("No puede eliminar al usuario ya que la sesión está activa, cierre sesión en todos los dispositivos y vuelva a intentarlo.", "Error de proceso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para buscar personas usando el texto ingresado en el campo de búsqueda.
        public void BuscarPeronasControllerEvent(object sender, EventArgs e)
        {
            BuscarPeronasController(); // Llama al método para realizar la búsqueda
        }

        // Método que realiza la búsqueda de personas y actualiza el DataGridView con los resultados.
        void BuscarPeronasController()
        {
            DAOAgregarUsuario objAdmin = new DAOAgregarUsuario(); // Crea una instancia del DAO para realizar la búsqueda
            DataSet ds = objAdmin.BuscarPersonas(ObjAdminUser.txtBuscador.Text.Trim()); // Obtiene los datos de búsqueda desde la base de datos
            ObjAdminUser.dgvEmpleados.DataSource = ds.Tables["RegistroEmpleado"]; // Asocia el DataSource del DataGridView con los datos obtenidos
        }

        // Método que abre un formulario para ver los detalles de la ficha del empleado seleccionado.
        private void VerFicha(object sender, EventArgs e)
        {
            int pos = ObjAdminUser.dgvEmpleados.CurrentRow.Index; // Obtiene la posición de la fila seleccionada
            int id;
            string Nombre, Apellido, CorreoEmpleado, Usuario, Role;
            DateTime FechaNacimient;

            // Captura los datos del empleado seleccionado
            id = int.Parse(ObjAdminUser.dgvEmpleados[0, pos].Value.ToString());
            Nombre = ObjAdminUser.dgvEmpleados[1, pos].Value.ToString();
            Apellido = ObjAdminUser.dgvEmpleados[2, pos].Value.ToString();
            FechaNacimient = DateTime.Parse(ObjAdminUser.dgvEmpleados[3, pos].Value.ToString());
            CorreoEmpleado = ObjAdminUser.dgvEmpleados[4, pos].Value.ToString();
            Usuario = ObjAdminUser.dgvEmpleados[5, pos].Value.ToString();
            Role = ObjAdminUser.dgvEmpleados[6, pos].Value.ToString();

            frmAgregarUsuario openForm = new frmAgregarUsuario(3); // Crea una nueva instancia del formulario para ver ficha
            openForm.ShowDialog(); // Muestra el formulario como un diálogo modal
            RefrescarData(); // Refresca los datos en el DataGridView después de cerrar el formulario
        }

    }
}
