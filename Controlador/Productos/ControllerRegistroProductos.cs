using Proyecto.Modelo.DAO;
using Proyecto.Vista.AgregarUsuarios;
using Proyecto.Vista.Producto;
using Proyecto.Vista.Proveedor;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Controlador.Productos
{
    internal class ControllerRegistroProductos
    {

        frmProducto vistaProducto;

        public ControllerRegistroProductos(frmProducto ObjProducto)
        {
            vistaProducto = ObjProducto; // Asocia el formulario actual con el controlador
            vistaProducto.Load += new EventHandler(CargarDatos); // Asocia el evento Load del formulario al método CargarDatos
            vistaProducto.btnNuevoProductos.Click += new EventHandler(nuevoProducto); // Asocia el evento Click del botón Nuevo Empleado al método nuevoUsuario
            //ObjAdminUser.btnActualizar.Click += new EventHandler(AcualizarEmpleado); // Asocia el evento Click del botón Actualizar al método ActualizarEmpleado
            vistaProducto.btnActualizarProveedor.Click += new EventHandler(AcualizarProducto);
            //vistaProducto.btnBuscarProducto.Click += new EventHandler(BuscarProductoController); // Asocia el evento Click del botón Buscar al método BuscarPeronasControllerEvent
        }

        public void CargarDatos(object sender, EventArgs e)
        {
            RefrescarData(); // Llama al método para actualizar los datos en el DataGridView
        }

        public void RefrescarData()
        {
            DAOProducto objAdmin = new DAOProducto(); // Crea una instancia del DAO para obtener datos
            DataSet ds = new DataSet();
            ds = objAdmin.ObetenerProductos();
            vistaProducto.dgvProductos.DataSource = ds.Tables["VistaProductos"];
        }

        private void nuevoProducto(object sender, EventArgs e)
        {
            frmAgregarProducto openForm = new frmAgregarProducto(1); // Crea una nueva instancia del formulario para agregar usuario
            openForm.ShowDialog(); // Muestra el formulario como un diálogo modal
            RefrescarData(); // Refresca los datos en el DataGridView después de cerrar el formulario
        }


        private void AcualizarProducto(object sender, EventArgs e)
        {
            int pos = vistaProducto.dgvProductos.CurrentRow.Index; // Obtiene la posición de la fila seleccionada en el DataGridView

            // Crea una nueva instancia del formulario para editar usuario con la acción de actualización
            frmAgregarProveedor openForm = new frmAgregarProveedor(2);

            // Enviar los datos de la fila seleccionada al formulario de edición
            int.Parse(vistaProducto.dgvProductos[0, pos].Value.ToString());
            vistaProducto.dgvProductos[1, pos].Value.ToString();

            openForm.ShowDialog(); // Muestra el formulario como un diálogo modal
            RefrescarData(); // Refresca los datos en el DataGridView después de cerrar el formulario
        }

        void BuscarProductoController()
        {
            DAOAgregarUsuario objAdmin = new DAOAgregarUsuario(); // Crea una instancia del DAO para realizar la búsqueda
            DataSet ds = objAdmin.BuscarPersonas(vistaProducto.txtBuscarProducto.Text.Trim()); // Obtiene los datos de búsqueda desde la base de datos
            vistaProducto.dgvProductos.DataSource = ds.Tables["VistaProductos"]; // Asocia el DataSource del DataGridView con los datos obtenidos
        }
    }
}
