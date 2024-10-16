using Proyecto.Modelo;
using Proyecto.Modelo.DAO;
using Proyecto.Vista.Dueño;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto.Controlador.Propietario
{
    internal class ControllerPropietario
    {
        frmAgregarDueñosMascotas objpropietario;
        public ControllerPropietario(frmAgregarDueñosMascotas vista)
        {
            objpropietario = vista;
            objpropietario.Load += new EventHandler(CargaDGV);
            objpropietario.btnIngresar.Click += new EventHandler(RegistrarPropietario);
            objpropietario.btnActualizar.Click += new EventHandler(ConfirmarActualizacion);
        }
        public void CargaDGV(object sender, EventArgs e)
        {
            RefreshData();
        }
        public void RefreshData()
        {
            DAOPropietario dao = new DAOPropietario();
            DataSet ds = dao.LLenarDGV();
        }
        private void TestConnection(object sender, EventArgs e)
        {
            //Se hace referencia a la clase dbContext y su método getConnection y se evalúa
            // si el retorno es nulo o no, en caso de ser nulo se mostrará el primer mensaje
            //de lo contrario se mostrará el código del segmento else.
            if (dbConexion.getConnection() == null)
            {
                MessageBox.Show("No fue posible realizar la conexión al servidor y/o la base de datos.", "Conexión fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                MessageBox.Show("La conexión al servidor y la base de datos se ha ejecutado correctamente.", "Conexión exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void RegistrarPropietario(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(objpropietario.txtNombre.Text.Trim()) || string.IsNullOrEmpty(objpropietario.txtApellido.Text.Trim()) || string.IsNullOrEmpty(objpropietario.txtTelefono.Text.Trim())))
            {
                DAOPropietario daoinsert = new DAOPropietario();
                daoinsert.Nombre = objpropietario.txtNombre.Text.Trim();
                daoinsert.Apellido = objpropietario.txtApellido.Text.Trim();
                daoinsert.Telefono = objpropietario.txtTelefono.Text.Trim();
                int valorretornado = daoinsert.RegistrarPropietario();
                if (valorretornado == 1)
                {
                    MessageBox.Show("Registro ingresado exitosamente", "Proceso completado con exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshData();
                }
                else
                {
                    MessageBox.Show("El registro no se pudo ingresar", "Proceso incompleto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Existen campos vacios obligatorios", "Proceso interrumpido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
       
        private void ConfirmarActualizacion(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(objpropietario.txtNombre.Text.Trim()) || string.IsNullOrEmpty(objpropietario.txtApellido.Text.Trim()) || string.IsNullOrEmpty(objpropietario.txtTelefono.Text.Trim())))
            {
                DAOPropietario daoupdate = new DAOPropietario();
                daoupdate.Nombre = objpropietario.txtNombre.Text.Trim();
                daoupdate.Apellido = objpropietario.txtApellido.Text.Trim();
                daoupdate.Telefono = objpropietario.txtTelefono.Text.Trim();
                int valorretornado = daoupdate.ActualizarPropietario();
                if (valorretornado == 1)
                {
                    MessageBox.Show("Registro actualizado exitosamente", "Proceso completado con exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    objpropietario.txtNombre.Clear();
                    objpropietario.txtApellido.Clear();
                    objpropietario.txtTelefono.Clear();
                    RefreshData();
                }
                else
                {
                    MessageBox.Show("El registro no se pudo actualizar", "Proceso incompleto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Existen campos vacios obligatorios", "Proceso interrumpido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

    }
}
