using Proyecto.Modelo.DAO;
using Proyecto.Vista.AgregarUsuarios;
using Proyecto.Vista.Mascota;
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

        public ControllerMascota(frmMascota vistaMascota)
        {
            ObjMascota = vistaMascota;

            ObjMascota.Load += new EventHandler(CargarDatos);

            ObjMascota.btnNuevaMascota.Click += new EventHandler(nuevoMascota);
            //ObjProveedor.cmsEliminar.Click += new EventHandler(EliminarProveedor);
            ObjMascota.btnActualizarMascota.Click += new EventHandler(ActualizarMascota);
            ObjMascota.btnBuscar.Click += new EventHandler(BuscarMascotaControllerEvent);
        }

        private void ActualizarMascota(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void NuevoMascota(object sender, EventArgs e)
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
            DAOMascotas objMascota = new DAOMascotas(); // Crea una instancia del DAO para obtener datos
            DataSet ds = new DataSet();
            ds = objMascota.ObtenerMascotas();
            ObjMascota.dgvMascotas.DataSource = ds.Tables["Mascota"]; // Asocia el DataSource del DataGridView con los datos obtenidos

        }

        private void nuevoMascota(object sender, EventArgs e)
        {
            frmMascota openForm = new frmMascota(1); // Crea una nueva instancia del formulario para agregar usuario
            openForm.ShowDialog(); // Muestra el formulario como un diálogo modal
            RefrescarData(); // Refresca los datos en el DataGridView después de cerrar el formulario
        }

        private void AcualizarMascota(object sender, EventArgs e)
        {
            int pos = ObjMascota.dgvMascotas.CurrentRow.Index; // Obtiene la posición de la fila seleccionada en el DataGridView

            // Crea una nueva instancia del formulario para editar usuario con la acción de actualización
            frmMascota openForm = new frmMascota(2);

            // Enviar los datos de la fila seleccionada al formulario de edición
            int.Parse(ObjMascota.dgvMascotas[0, pos].Value.ToString());
            ObjMascota.dgvMascotas[1, pos].Value.ToString();

            openForm.ShowDialog(); // Muestra el formulario como un diálogo modal
            RefrescarData(); // Refresca los datos en el DataGridView después de cerrar el formulario
        }

        public void BuscarMascotaControllerEvent(object sender, EventArgs e)
        {
            BuscarMascotaController(); // Llama al método para realizar la búsqueda
        }

        // Método que realiza la búsqueda de personas y actualiza el DataGridView con los resultados.
        void BuscarMascotaController()
        {
            DAOAgregarUsuario objAdmin = new DAOAgregarUsuario(); // Crea una instancia del DAO para realizar la búsqueda
            DataSet ds = objAdmin.BuscarPersonas(ObjMascota.txtBuscadorProveedor.Text.Trim()); // Obtiene los datos de búsqueda desde la base de datos
            ObjMascota.dgvMascotas.DataSource = ds.Tables["Mascota"]; // Asocia el DataSource del DataGridView con los datos obtenidos
        }
    }

}