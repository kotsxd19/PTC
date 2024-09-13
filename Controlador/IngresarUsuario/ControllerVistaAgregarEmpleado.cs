using Proyecto.Modelo.DAO;
using Proyecto.Vista.AgregarUsuarios;
using System;
using System.Collections.Generic;
using System.Data;
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
        public ControllerVistaAgregarEmpleado(frmRegistroUsuario Vista)
        {
            ObjAdminUser = Vista;
            ObjAdminUser.btnRecargar.Click += new EventHandler(CargarDatos);
            //Evento click de botón
            ObjAdminUser.btnNuevoEmpleado.Click += new EventHandler(nuevoUsuario);
            ObjAdminUser.btnActualizar.Click += new EventHandler(AcualizarEmpleado);
            ObjAdminUser.cmsEliminar.Click += new EventHandler(DeleteUser);
            ObjAdminUser.cmsFicha.Click += new EventHandler(VerFicha);
            //ObjAdminUser.txtSearch.KeyPress += new KeyPressEventHandler(Search);
            ObjAdminUser.btnBuscar.Click += new EventHandler(BuscarPeronasControllerEvent);
        }

        public void CargarDatos(object sender, EventArgs e)
        {
            RefrescarData();
        }

        public void RefrescarData()
        {
            DAOAgregarUsuario objAdmin = new DAOAgregarUsuario();
            DataSet ds = new DataSet();

            if (ObjAdminUser.btnRecargar.Focused)
            {
                ds = objAdmin.ObtenerPersonas();


            }
            ObjAdminUser.dgvEmpleados.DataSource = ds.Tables["Empleado"];
            ObjAdminUser.dgvEmpleados.Columns[0].Visible = false;
            ObjAdminUser.dgvEmpleados.Columns[3].Visible = false;
            ObjAdminUser.dgvEmpleados.Columns[10].Visible = false;
        }


        private void nuevoUsuario(object sender, EventArgs e)
        {
            frmAgregarUsuario openForm = new frmAgregarUsuario();
            //Se muestra el formulario
            openForm.ShowDialog();
            //Cuando el formulario ha sido cerrado se procede a refrescar el DataGrid para que se puedan observar los nuevo datos ingresados o actualizados.
            RefrescarData();
        }

        private void AcualizarEmpleado(object sender, EventArgs e)
        {
            //Se captura el numero de la fila a la cual se le dió click, sabiendo que la primer fila tiene como valor cero.
            int pos = ObjAdminUser.dgvEmpleados.CurrentRow.Index;
            /*Se invoca al formulario llamado ViewAddUser y se crea un objeto de el, posteriormente se envían los datos del datagrid al constructor del formulario según el orden establecido (se sugiere ver el código del formulario para observar ambos constructores).
             * El numero dos indicado en la linea posterior significa que la acción que se desea realizar es una actualízación.*/
            frmAgregarUsuario openForm = new frmAgregarUsuario();
            ObjAdminUser.dgvEmpleados[1, pos].Value.ToString();
            ObjAdminUser.dgvEmpleados[2, pos].Value.ToString();
            DateTime.Parse(ObjAdminUser.dgvEmpleados[3, pos].Value.ToString());
            ObjAdminUser.dgvEmpleados[4, pos].Value.ToString();
            //Una vez los datos han sido enviados al constructor de la vista se procede a mostrar el formulario (se sugiere ver el código del constructor que esta en la vista)
            openForm.ShowDialog();
            //Una vez el formulario se haya cerrado se procederá a refrescar el dataGrid para mostrar los nuevos datos.
            RefrescarData();
        }

        private void DeleteUser(object sender, EventArgs e)
        {
            int pos = ObjAdminUser.dgvEmpleados.CurrentRow.Index;
            string userSelected = ObjAdminUser.dgvEmpleados[8, pos].Value.ToString();
            MessageBox.Show($"{userSelected}");
            if (!(userSelected.Equals(Acceso.Usuario) || userSelected.Equals("Engineer")))
            {
                if (MessageBox.Show($"• Se eliminará la información de la persona, sin embargo, el usuario asociado quedará inactivo.\n\n• ¿Esta seguro que desea elimar a: {ObjAdminUser.dgvEmpleados[1, pos].Value.ToString()} {ObjAdminUser.dgvEmpleados[2, pos].Value.ToString()}, considere que dicha acción no se podrá revertir. \n\n• Si desea mantener la información utilice la opción de deshabilitar usuario.", "Confirmar acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DAOAgregarUsuario daoDel = new DAOAgregarUsuario();
                    daoDel.IdEmpleado1 = int.Parse(ObjAdminUser.dgvEmpleados[0, pos].Value.ToString());
                    daoDel.Usuario1 = ObjAdminUser.dgvEmpleados[8, pos].Value.ToString();
                    int valorRetornado = daoDel.EliminarEmplado();
                    if (valorRetornado == 2)
                    {
                        MessageBox.Show("Registro eliminado", "Acción completada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefrescarData();
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

        public void BuscarPeronasControllerEvent(object sender, EventArgs e) { BuscarPeronasController(); }

        void BuscarPeronasController()
        {
            //Objeto de la clase DAOAdminUsuarios
            DAOAgregarUsuario objAdmin = new DAOAgregarUsuario();
            //Declarando nuevo DataSet para que obtenga los datos del metodo ObtenerPersonas
            DataSet ds = objAdmin.BuscarPersonas(ObjAdminUser.txtBuscador.Text.Trim());
            //Llenar DataGridView
            ObjAdminUser.dgvEmpleados.DataSource = ds.Tables["RegistroEmpleado"];
        }

        private void VerFicha(object sender, EventArgs e)
        {
            int pos = ObjAdminUser.dgvEmpleados.CurrentRow.Index;
            int id;
            string Nombre, Apellido, CorreoEmpleado, Usuario, Role;
            DateTime FechaNacimient;

            id = int.Parse(ObjAdminUser.dgvEmpleados[0, pos].Value.ToString());
            Nombre = ObjAdminUser.dgvEmpleados[1, pos].Value.ToString();
            Apellido = ObjAdminUser.dgvEmpleados[2, pos].Value.ToString();
            FechaNacimient = DateTime.Parse(ObjAdminUser.dgvEmpleados[3, pos].Value.ToString());
            CorreoEmpleado = ObjAdminUser.dgvEmpleados[4, pos].Value.ToString();
            Usuario = ObjAdminUser.dgvEmpleados[5, pos].Value.ToString();
            Role = ObjAdminUser.dgvEmpleados[6, pos].Value.ToString();

            frmAgregarUsuario openForm = new frmAgregarUsuario();
            openForm.ShowDialog();
            RefrescarData();
        }
    }
}
