using Proyecto.Modelo.DAO;
using Proyecto.Vista.AgregarUsuarios;
using Proyecto.Vista.Dueño;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Controlador.Proveedor
{
    internal class ControllerPropietarios
    {
        frmDueño Objpropietario;

        public ControllerPropietarios(frmDueño vista)
        {
            Objpropietario = vista;

            Objpropietario.Load += new EventHandler(CargarDatos);
            Objpropietario.cbEstadoPropietario.CheckedChanged += new EventHandler(CambiarConsulta);
            Objpropietario.btnNuevoEmpleado.Click += new EventHandler(nuevoDueño);
            Objpropietario.btnBuscar.Click += new EventHandler(BuscarDueño);
        }



        public void CargarDatos(object sender, EventArgs e)
        {
            RefrescarData(); // Llama al método para actualizar los datos en el DataGridView
        }

        private void CambiarConsulta(object sender, EventArgs e)
        {
            RefrescarData();
        }

        // Método que refresca los datos en el DataGridView.
        public void RefrescarData()
        {
            DAOPropietario objAdmin = new DAOPropietario(); // Crea una instancia del DAO para obtener datos
            DataSet ds = new DataSet();
            if (Objpropietario.cbEstadoPropietario.Checked != true)
            {
                ds = objAdmin.ObtenerPersonasActivas(); // Obtiene la lista de personas desde la base de datos
                Objpropietario.dgvEmpleados.DataSource = ds.Tables["Propietario"];
            }
            else
            {
                ds = objAdmin.ObtenerPersonasInactivas();
                Objpropietario.dgvEmpleados.DataSource = ds.Tables["Propietario"]; // Asocia el DataSource del DataGridView con los datos obtenidos
            }

        }

        private void nuevoDueño(object sender, EventArgs e)
        {
            frmAgregarDueñosMascotas openForm = new frmAgregarDueñosMascotas(); // Crea una nueva instancia del formulario para agregar usuario
            openForm.ShowDialog(); // Muestra el formulario como un diálogo modal
            RefrescarData(); // Refresca los datos en el DataGridView después de cerrar el formulario
        }

        public void BuscarDueño(object sender, EventArgs e)
        {
            BuscardueñoController(); // Llama al método para realizar la búsqueda
        }

        // Método que realiza la búsqueda de personas y actualiza el DataGridView con los resultados.
        void BuscardueñoController()
        {
            DAOPropietario objAdmin = new DAOPropietario(); // Crea una instancia del DAO para realizar la búsqueda
            DataSet ds = objAdmin.BuscarPropietario(Objpropietario.txtBuscador.Text.Trim()); // Obtiene los datos de búsqueda desde la base de datos
            Objpropietario.dgvEmpleados.DataSource = ds.Tables["Propietario"]; // Asocia el DataSource del DataGridView con los datos obtenidos
        }

    }
}