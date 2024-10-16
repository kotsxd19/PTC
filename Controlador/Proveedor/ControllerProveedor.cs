using Proyecto.Modelo.DAO;
using Proyecto.Vista.AgregarUsuarios;
using Proyecto.Vista.Proveedor;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Controlador.Proveedor
{
    internal class ControllerProveedor
    {
        frmProveedor ObjMascota;

        public ControllerProveedor(frmProveedor vistaProveedor)
        {
            ObjMascota = vistaProveedor;

<<<<<<< Updated upstream
            ObjProveedor.Load += new EventHandler(CargarDatos);
            ObjProveedor.cbEstado.CheckedChanged += new EventHandler(CambiarConsulta); 
            ObjProveedor.btnNuevoProveedor.Click += new EventHandler(nuevoProveedor);
=======
            ObjMascota.Load += new EventHandler(CargarDatos);

            ObjMascota.btnNuevoProveedor.Click += new EventHandler(nuevoProveedor);
>>>>>>> Stashed changes
            //ObjProveedor.cmsEliminar.Click += new EventHandler(EliminarProveedor);
            ObjMascota.btnActualizarProveedor.Click += new EventHandler(AcualizarProveedor);
            ObjMascota.btnBuscarProveedor.Click += new EventHandler(BuscarProveedorControllerEvent); 
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
            DAOProveedor objAdmin = new DAOProveedor(); // Crea una instancia del DAO para obtener datos
            DataSet ds = new DataSet();
<<<<<<< Updated upstream
            if (ObjProveedor.cbEstado.Checked != true)
            {
                ds = objAdmin.ObtenerProveedorActivas(); // Obtiene la lista de personas desde la base de datos
                ObjProveedor.dgvProveedor.DataSource = ds.Tables["Proveedor"];
            }
            else
            {
                ds = objAdmin.ObtenerProveedorInactivos();
                ObjProveedor.dgvProveedor.DataSource = ds.Tables["Proveedor"]; // Asocia el DataSource del DataGridView con los datos obtenidos
            }
=======
            ds = objProveerdor.ObtenerProveedor();
            ObjMascota.dgvProveedor.DataSource = ds.Tables["Proveedor"]; // Asocia el DataSource del DataGridView con los datos obtenidos
            
>>>>>>> Stashed changes
        }


        private void nuevoProveedor(object sender, EventArgs e)
        {
            frmAgregarProveedor openForm = new frmAgregarProveedor(1); // Crea una nueva instancia del formulario para agregar usuario
            openForm.ShowDialog(); // Muestra el formulario como un diálogo modal
            RefrescarData(); // Refresca los datos en el DataGridView después de cerrar el formulario
        }

        private void AcualizarProveedor(object sender, EventArgs e)
        {
            int pos = ObjMascota.dgvProveedor.CurrentRow.Index; // Obtiene la posición de la fila seleccionada en el DataGridView

            // Crea una nueva instancia del formulario para editar usuario con la acción de actualización
            frmAgregarProveedor openForm = new frmAgregarProveedor(2);

            // Enviar los datos de la fila seleccionada al formulario de edición
            int.Parse(ObjMascota.dgvProveedor[0, pos].Value.ToString());
            ObjMascota.dgvProveedor[1, pos].Value.ToString();

            openForm.ShowDialog(); // Muestra el formulario como un diálogo modal
            RefrescarData(); // Refresca los datos en el DataGridView después de cerrar el formulario
        }

        public void BuscarProveedorControllerEvent(object sender, EventArgs e)
        {
            BuscarProveedorController(); // Llama al método para realizar la búsqueda
        }

        // Método que realiza la búsqueda de personas y actualiza el DataGridView con los resultados.
        void BuscarProveedorController()
        {
            DAOAgregarUsuario objAdmin = new DAOAgregarUsuario(); // Crea una instancia del DAO para realizar la búsqueda
            DataSet ds = objAdmin.BuscarPersonas(ObjMascota.txtBuscadorProveedor.Text.Trim()); // Obtiene los datos de búsqueda desde la base de datos
            ObjMascota.dgvProveedor.DataSource = ds.Tables["Proveedor"]; // Asocia el DataSource del DataGridView con los datos obtenidos
        }
    }
}
