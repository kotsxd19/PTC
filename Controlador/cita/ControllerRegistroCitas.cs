using Proyecto.Modelo.DAO;
using Proyecto.Vista.citas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto.Controlador.cita
{
    internal class ControllerRegistroCitas
    {
        // Referencia a la vista del formulario
        frmAgregarCitas objVista;
        frmcitas agregarCitas;

        // Constructor que inicializa el controlador y sus eventos
        public ControllerRegistroCitas(frmAgregarCitas Vista)
        {
            objVista = Vista;
            objVista.Load += new EventHandler(CargarDatos);
            objVista.cbCitasInactivas.CheckedChanged += new EventHandler(CambiarConsulta);
            // Asignar eventos a los botones de la vista
            //Vista.btnActualizarCita.Click += new EventHandler(EditarCita);
            Vista.btnNuevaCita.Click += new EventHandler(IngresarCita);

            // Llenar el DataGridView al inicializar
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
            DAOCitas objAdmin = new DAOCitas(); // Crea una instancia del DAO para obtener datos
            DataSet ds = new DataSet();

            if (objVista.cbCitasInactivas.Checked != true)
            {
                ds = objAdmin.ObtenerMascotasActivas(); // Obtiene la lista de personas desde la base de datos
                objVista.dgvCitas.DataSource = ds.Tables["ViewCita"];
            }
            else
            {
                ds = objAdmin.ObtenerMascotasInactivas();
                objVista.dgvCitas.DataSource = ds.Tables["ViewCita"]; // Asocia el DataSource del DataGridView con los datos obtenidos
            }
        }

        // Método para eliminar una cita

        // Método para ingresar una nueva cita
        private void IngresarCita(object sender, EventArgs e)
        {
            frmcitas openForm = new frmcitas();
            openForm.ShowDialog();

        }

        // Método para editar una cita existente
        //private void EditarCita(object sender, EventArgs e)
        //{
        //    //Obtener la posición de la fila seleccionada
        //    int pos = objVista.dgvCitas.CurrentRow.Index;

        //    // Crear instancia de DAOCitas para editar
        //    DAOCitas daoUpdate = new DAOCitas();

        //    int IdCitas = int.Parse(objVista.dgvCitas[0, pos].Value.ToString()); // Obtener el ID de la cita
        //    int IdEmpleados = int.Parse(agregarCitas.cmbEmpleado.Text); // ID del empleado
        //    int IdMascota = int.Parse(agregarCitas.cmbMascotas.Text); // ID de la mascota
        //    DateTime Fecha = DateTime.Parse(agregarCitas.dtpFecha.Value.ToString("yyyy-MM-dd")); // Fecha de la cita
        //    TimeSpan Hora = TimeSpan.Parse(agregarCitas.dtpHora.Value.ToString("HH:mm:ss")); // Hora de la cita
        //    string Descripcion = agregarCitas.txtDescripcion.Text; // Descripción de la cita

        //    frmcitas openForm = new frmcitas(IdCitas, IdEmpleados, IdMascota, Fecha, Hora, Descripcion);
        //    openForm.ShowDialog();
        //    //Llamar al método de actualización y verificar el resultado
        //    int retorno = daoUpdate.EditarCita();
        //    if (retorno == 1)
        //    {
        //        MessageBox.Show("La cita fue actualizada exitosamente", "Proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        LlenarDataGridInfoCitas(); // Actualizar el DataGridView
        //    }
        //    else
        //    {
        //        MessageBox.Show("La cita no pudo ser actualizada", "Proceso incompleto", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}
    }
}
