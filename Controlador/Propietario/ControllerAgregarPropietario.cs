using Proyecto.Controlador.Validar;
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
            objpropietario.Load += new EventHandler(CargarDatos);
            objpropietario.btnIngresar.Click += new EventHandler(RegistrarPropietario);
        }

        public ControllerPropietario(frmDueño frmDueño)
        {
        }

        private void CargarDatos(object sender, EventArgs e)
        {
            objpropietario.cmbEstado.Enabled = true;

            objpropietario.cmbEstado.Items.Clear();

            objpropietario.cmbEstado.Items.Add(new KeyValuePair<string, int>("Activo", 1));
            objpropietario.cmbEstado.Items.Add(new KeyValuePair<string, int>("Inactivo", 2));

            objpropietario.cmbEstado.DisplayMember = "Key";

            objpropietario.cmbEstado.ValueMember = "Value";

            objpropietario.cmbEstado.SelectedIndex = 0; // Esto selecciona "Activo" por defecto

            // Evita acceder al SelectedItem inmediatamente después de la carga
            objpropietario.cmbEstado.SelectedIndexChanged += (s, ev) =>
            {
                if (objpropietario.cmbEstado.SelectedItem != null)
                {
                    int estadoSeleccionado = ((KeyValuePair<String, int>)objpropietario.cmbEstado.SelectedItem).Value;
                }
            };
        }

        private void RegistrarPropietario(object sender, EventArgs e)
        {
            try
            {
                if (!(string.IsNullOrEmpty(objpropietario.txtNombre.Text.Trim()) ||
                string.IsNullOrEmpty(objpropietario.txtApellido.Text.Trim()) ||
                string.IsNullOrEmpty(objpropietario.cmbEstado.Text.Trim()) ||
                string.IsNullOrEmpty(objpropietario.txtTelefono.Text.Trim())))
                {
                    DAOPropietario DAOInsert = new DAOPropietario();
                    DAOInsert.Nombre = objpropietario.txtNombre.Text.Trim();
                    DAOInsert.Apellido = objpropietario.txtApellido.Text.Trim();
                    DAOInsert.Telefono = objpropietario.txtTelefono.Text.Trim();

                    int estadoSeleccionado = ((KeyValuePair<string, int>)objpropietario.cmbEstado.SelectedItem).Value;
                    DAOInsert.EstadoPropietario1 = estadoSeleccionado == 1;


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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
