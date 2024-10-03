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

        // Constructor que inicializa el controlador y sus eventos
        public ControllerCitas(frmCitas Vista)
        {
            objVista = Vista;

            // Asignar eventos a los botones de la vista
            Vista.btnEliminarCita.Click += new EventHandler(EliminarCita);
            Vista.btnEditarCita.Click += new EventHandler(EditarCita);
            Vista.btnIngresarCita.Click += new EventHandler(IngresarCita);

            // Llenar el DataGridView al inicializar
            LlenarDataGridInfoCitas();
        }

        void LLenarcomboEmpleados()
        {

            DAOCitas daoCitas = new DAOCitas();
            DataSet ds = daoCitas.LLenarcomboEmpleados();
            objVista.cmbIdEmpleados.DataSource = ds.Tables["Empleado"];
            objVista.cmbIdEmpleados.DisplayMember = "Nombre";
            objVista.cmbIdEmpleados.ValueMember = "IdEmpleado";
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
            try
            {
                // Crear una nueva instancia de DAOCitas para insertar
                DAOCitas daoInsert = new DAOCitas();

                int IdEmpleados = int.Parse(objVista.cmbIdEmpleados.Text); // ID del empleado
                int IdMascota = int.Parse(objVista.txtIdMascota.Text); // ID de la mascota
                DateTime Fecha = DateTime.Parse(objVista.dtpFecha.Value.ToString("yyyy-MM-dd")); // Fecha de la cita
                TimeSpan Hora = TimeSpan.Parse(objVista.dtpHora.Value.ToString("HH:mm:ss")); // Hora de la cita
                string Descripcion = objVista.txtDescripcion.Text; // Descripción de la cita


                // Llamar al método de inserción y verificar el resultado
                int retorno = daoInsert.IngresarCita();
                if (retorno == 1)
                {
                    MessageBox.Show("La cita se agregó exitosamente", "Proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LlenarDataGridInfoCitas(); // Actualizar el DataGridView
                }
                else
                {
                    MessageBox.Show("No se pudo agregar la cita", "Proceso incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                // Manejo de errores al agregar la cita
                MessageBox.Show("Error al agregar la cita: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para editar una cita existente
        private void EditarCita(object sender, EventArgs e)
        {
            // Obtener la posición de la fila seleccionada
            int pos = objVista.dgvCitas.CurrentRow.Index;

            // Crear instancia de DAOCitas para editar
            DAOCitas daoUpdate = new DAOCitas();

            int IdCitas = int.Parse(objVista.dgvCitas[0, pos].Value.ToString()); // Obtener el ID de la cita
            int IdEmpleados = int.Parse(objVista.cmbIdEmpleados.Text); // ID del empleado
            int IdMascota = int.Parse(objVista.txtIdMascota.Text); // ID de la mascota
            DateTime Fecha = DateTime.Parse(objVista.dtpFecha.Value.ToString("yyyy-MM-dd")); // Fecha de la cita
            TimeSpan Hora = TimeSpan.Parse(objVista.dtpHora.Value.ToString("HH:mm:ss")); // Hora de la cita
            string Descripcion = objVista.txtDescripcion.Text; // Descripción de la cita
            

            // Llamar al método de actualización y verificar el resultado
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
