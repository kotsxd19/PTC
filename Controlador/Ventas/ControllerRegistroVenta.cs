using Proyecto.Modelo.DAO;
using Proyecto.Vista.Mascota;
using Proyecto.Vista.Ventas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Controlador.Ventas
{
    internal class ControllerRegistroVenta
    {
        frmVentas objVentas;


        public ControllerRegistroVenta(frmVentas vistaProveedor)
        {
            objVentas = vistaProveedor;


            objVentas.Load += new EventHandler(CargarDatos);
            objVentas.cbEstadoAnimal.CheckedChanged += new EventHandler(CambiarConsulta);
            objVentas.btnAgregarVenta.Click += new EventHandler(nuevaMascota);

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
            DAOMascotas objAdmin = new DAOMascotas(); // Crea una instancia del DAO para obtener datos
            DataSet ds = new DataSet();

            if (objVentas.cbEstadoAnimal.Checked != true)
            {
                ds = objAdmin.ObtenerMascotasActivas(); // Obtiene la lista de personas desde la base de datos
                objVentas.dgvVenta.DataSource = ds.Tables["ViewVentas"];
            }
            else
            {
                ds = objAdmin.ObtenerMascotasInactivas();
                objVentas.dgvVenta.DataSource = ds.Tables["ViewVentas"]; // Asocia el DataSource del DataGridView con los datos obtenidos
            }
        }


        private void nuevaMascota(object sender, EventArgs e)
        {
            frmAgregarVentas openForm = new frmAgregarVentas(); // Crea una nueva instancia del formulario para agregar usuario
            openForm.ShowDialog(); // Muestra el formulario como un diálogo modal
            RefrescarData(); // Refresca los datos en el DataGridView después de cerrar el formulario
        }
    }
}
