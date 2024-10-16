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
    internal class ControllerPropietario
    {
        frmDueño Objpropietario;

        public ControllerPropietario(frmDueño vistaPropietario)
        {
            Objpropietario = vistaPropietario;

            Objpropietario.Load += new EventHandler(CargarDatos);

            Objpropietario.btnNuevoEmpleado.Click += new EventHandler(nuevoDueño);
            //ObjProveedor.cmsEliminar.Click += new EventHandler(EliminarProveedor);
            Objpropietario.btnActualizar.Click += new EventHandler(AcualizarDueño);
            Objpropietario.btnBuscar.Click += new EventHandler(BuscarDueñoControllerEvent);
        }

        private void BuscarDueñoControllerEvent(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        public void CargarDatos(object sender, EventArgs e)
        {
            RefrescarData(); // Llama al método para actualizar los datos en el DataGridView
        }

        // Método que refresca los datos en el DataGridView.
        public void RefrescarData()
        {
            DAOPropietario objpropietario = new DAOPropietario(); // Crea una instancia del DAO para obtener datos
            DataSet ds = new DataSet();
            ds = objpropietario.ObtenerDueño();
            Objpropietario.dgvEmpleados.DataSource = ds.Tables["Propietario"]; // Asocia el DataSource del DataGridView con los datos obtenidos

        }

        private void nuevoDueño(object sender, EventArgs e)
        {
            frmAgregarDueñosMascotas openForm = new frmAgregarDueñosMascota(1); // Crea una nueva instancia del formulario para agregar usuario
            openForm.ShowDialog(); // Muestra el formulario como un diálogo modal
            RefrescarData(); // Refresca los datos en el DataGridView después de cerrar el formulario
        }

        private void AcualizarDueño(object sender, EventArgs e)
        {
            int pos = Objpropietario.dgvEmpleados.CurrentRow.Index; // Obtiene la posición de la fila seleccionada en el DataGridView

            // Crea una nueva instancia del formulario para editar usuario con la acción de actualización
            frmAgregarDueñosMascota openForm = new frmAgregarDueñosMascota(2);

            // Enviar los datos de la fila seleccionada al formulario de edición
            int.Parse(Objpropietario.dgvEmpleados[0, pos].Value.ToString());
            Objpropietario.dgvEmpleados[1, pos].Value.ToString();

            openForm.ShowDialog(); // Muestra el formulario como un diálogo modal
            RefrescarData(); // Refresca los datos en el DataGridView después de cerrar el formulario
        }

        public void BuscarpropietarioControllerEvent(object sender, EventArgs e)
        {
            BuscarDueñoController(); // Llama al método para realizar la búsqueda
        }

        // Método que realiza la búsqueda de personas y actualiza el DataGridView con los resultados.
        void BuscarDueñoController()
        {
            DAOAgregarUsuario objAdmin = new DAOAgregarUsuario(); // Crea una instancia del DAO para realizar la búsqueda
            DataSet ds = objAdmin.BuscarPersonas(Objpropietario.txtBuscador.Text.Trim()); // Obtiene los datos de búsqueda desde la base de datos
            Objpropietario.dgvEmpleados.DataSource = ds.Tables["Propietario"]; // Asocia el DataSource del DataGridView con los datos obtenidos
        }
    }

    internal class frmAgregarDueñosMascota : frmAgregarDueñosMascotas
    {
        private int v;

        public frmAgregarDueñosMascota(int v)
        {
            this.v = v;
        }
    }
}