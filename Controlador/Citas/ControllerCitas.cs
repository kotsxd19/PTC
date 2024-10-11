using Proyecto.Modelo.DAO;
using Proyecto.Vista.InterfazCitas;
using System;
using System.Data;
using System.Windows.Forms;

namespace Proyecto.Controlador.Citas
{
    internal class ControllerCitas
    {
        // Referencia a la vista del formulario
        frmCitas objVista;
        frmAgregarCitas agregarCitas;

        // Constructor que inicializa el controlador y sus eventos
        public ControllerCitas(frmCitas Vista)
        {
            objVista = Vista;
            Vista.Load += new EventHandler(iniciarCarga);
            // Asignar eventos a los botones de la vista
            Vista.btnEliminarCita.Click += new EventHandler(EliminarCita);
            Vista.btnEditarCita.Click += new EventHandler(EditarCita);
            Vista.btnIngresarCita.Click += new EventHandler(IngresarCita);

            // Llenar el DataGridView al inicializar
            LlenarDataGridInfoCitas();
        }

        private void iniciarCarga(object sender, EventArgs e)
        {
            LlenarDataGridInfoCitas();

        }



        // Método para llenar el DataGridView con información de citas
        public void LlenarDataGridInfoCitas()
        {
            DAOCitas daoCitas = new DAOCitas();
            DataSet ds = new DataSet();
            objVista.dgvInfoCitas.DataSource = ds.Tables["Citas"]; // Asignar la fuente de datos al DataGridView
        }

        // Método para eliminar una cita
        private void EliminarCita(object sender, EventArgs e)
        {
            // Obtener la posición de la fila seleccionada
            int pos = objVista.dgvCitas.CurrentRow.Index;

            // Crear instancia de DAOCitas para eliminar
            DAOCitas daoDelete = new DAOCitas
            {
                IdCitas = int.Parse(objVista.dgvCitas[0, pos].Value.ToString()) // Obtener el ID de la cita
            };

            // Llamar al método de eliminación y verificar el resultado
            int retorno = daoDelete.EliminarCita();
            if (retorno == 1)
            {
                MessageBox.Show("La cita seleccionada fue eliminada", "Proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LlenarDataGridInfoCitas(); // Actualizar el DataGridView
            }
            else
            {
                MessageBox.Show("La cita seleccionada no pudo ser eliminada", "Proceso incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Método para ingresar una nueva cita
        private void IngresarCita(object sender, EventArgs e)
        {
            frmAgregarCitas openForm = new frmAgregarCitas();
            openForm.ShowDialog();
           
        }

        // Método para editar una cita existente
        private void EditarCita(object sender, EventArgs e)
        {
            //Obtener la posición de la fila seleccionada
            int pos = objVista.dgvCitas.CurrentRow.Index;

            // Crear instancia de DAOCitas para editar
            DAOCitas daoUpdate = new DAOCitas();

            int IdCitas = int.Parse(objVista.dgvCitas[0, pos].Value.ToString()); // Obtener el ID de la cita
            int IdEmpleados = int.Parse(agregarCitas.cmbIdEmpleados.Text); // ID del empleado
            int IdMascota = int.Parse(agregarCitas.txtIdMascota.Text); // ID de la mascota
            DateTime Fecha = DateTime.Parse(agregarCitas.dtpFecha.Value.ToString("yyyy-MM-dd")); // Fecha de la cita
            TimeSpan Hora = TimeSpan.Parse(agregarCitas.dtpHora.Value.ToString("HH:mm:ss")); // Hora de la cita
            string Descripcion = agregarCitas.txtDescripcion.Text; // Descripción de la cita

            frmAgregarCitas openForm = new frmAgregarCitas(IdCitas, IdEmpleados, IdMascota, Fecha, Hora, Descripcion);
            openForm.ShowDialog();
            //Llamar al método de actualización y verificar el resultado
            int retorno = daoUpdate.EditarCita();
            if (retorno == 1)
            {
                MessageBox.Show("La cita fue actualizada exitosamente", "Proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LlenarDataGridInfoCitas(); // Actualizar el DataGridView
            }
            else
            {
                MessageBox.Show("La cita no pudo ser actualizada", "Proceso incompleto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
