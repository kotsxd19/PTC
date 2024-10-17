using Proyecto.Modelo.DAO;
using Proyecto.Vista.AgregarUsuarios;
using Proyecto.Vista.Mascota;
using Proyecto.Vista.Proveedor;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Controlador.Mascota
{
    internal class ControllerMascota
    {
        frmMascota ObjMascota;

        public ControllerMascota(frmMascota vistaProveedor)
        {
            ObjMascota = vistaProveedor;


            ObjMascota.Load += new EventHandler(CargarDatos);
            ObjMascota.cbEstadoAnimal.CheckedChanged += new EventHandler(CambiarConsulta);
            ObjMascota.btnNuevaMascota.Click += new EventHandler(nuevaMascota);

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

            if (ObjMascota.cbEstadoAnimal.Checked != true)
            {
                ds = objAdmin.ObtenerMascotasActivas(); // Obtiene la lista de personas desde la base de datos
                ObjMascota.dgvMascotas.DataSource = ds.Tables["ViewDogs"];
            }
            else
            {
                ds = objAdmin.ObtenerMascotasInactivas();
                ObjMascota.dgvMascotas.DataSource = ds.Tables["ViewDogs"]; // Asocia el DataSource del DataGridView con los datos obtenidos
            }
        }


        private void nuevaMascota(object sender, EventArgs e)
        {
            frmAgregarMascota openForm = new frmAgregarMascota(); // Crea una nueva instancia del formulario para agregar usuario
            openForm.ShowDialog(); // Muestra el formulario como un diálogo modal
            RefrescarData(); // Refresca los datos en el DataGridView después de cerrar el formulario
        }

    }

}