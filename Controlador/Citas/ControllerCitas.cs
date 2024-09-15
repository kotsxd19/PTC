using Proyecto.Modelo.DAO;
using Proyecto.Vista.InterfazCitas;
using System;
using System.Data;
using System.Windows.Forms;

namespace Proyecto.Controlador.Citas
{
    internal class ControllerCitas
    {
        frmCitas objVista;

        public ControllerCitas(frmCitas Vista)
        {
            objVista = Vista;
            Vista.btnEliminarCita.Click += new EventHandler(EliminarCita);
            Vista.btnEditarCita.Click += new EventHandler(EditarCita);
            Vista.btnIngresarCita.Click += new EventHandler(IngresarCita);

            // Se llena el DataGridView en la inicialización
            LlenarDataGridInfoCitas();
        }

        public void LlenarDataGridInfoCitas()
        {
            DAOCitas daoCitas = new DAOCitas();
            DataSet ds = daoCitas.ObtenerCitas();
            objVista.dgvInfoCitas.DataSource = ds.Tables["Citas"];
        }

        private void EliminarCita(object sender, EventArgs e)
        {
            int pos = objVista.dgvCitas.CurrentRow.Index;
            DAOCitas daoDelete = new DAOCitas
            {
                IdCita = int.Parse(objVista.dgvCitas[0, pos].Value.ToString())
            };
            int retorno = daoDelete.EliminarCita();
            if (retorno == 1)
            {
                MessageBox.Show("La cita seleccionada fue eliminada", "Proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LlenarDataGridInfoCitas();
            }
            else
            {
                MessageBox.Show("La cita seleccionada no pudo ser eliminada", "Proceso incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void IngresarCita(object sender, EventArgs e)
        {
            try
            {
                DAOCitas daoInsert = new DAOCitas
                {
                    IdEmpleado = int.Parse(objVista.txtIdEmpleados.Text),
                    IdMascota = int.Parse(objVista.txtIdMascota.Text),
                    Fecha = DateTime.Parse(objVista.dtpFecha.Value.ToString("yyyy-MM-dd")),
                    Hora = TimeSpan.Parse(objVista.dtpHora.Text),
                    Descripcion = objVista.txtDescripcion.Text
                };

                int retorno = daoInsert.IngresarCita();

                if (retorno == 1)
                {
                    MessageBox.Show("La cita se agrego exitosamente", "Proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LlenarDataGridInfoCitas();
                }
                else
                {
                    MessageBox.Show("No se pudo agregar la cita", "Proceso incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar la cita: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditarCita(object sender, EventArgs e)
        {
            int pos = objVista.dgvCitas.CurrentRow.Index;
            DAOCitas daoUpdate = new DAOCitas
            {
                IdCita = int.Parse(objVista.dgvCitas[0, pos].Value.ToString()),
                IdEmpleado = int.Parse(objVista.txtIdEmpleados.Text),
                IdMascota = int.Parse(objVista.txtIdMascota.Text),
                Fecha = DateTime.Parse(objVista.dtpFecha.Value.ToString("yyyy-MM-dd")),
                Hora = TimeSpan.Parse(objVista.dtpHora.Text),
                Descripcion = objVista.txtDescripcion.Text
            };

            int retorno = daoUpdate.EditarCita();
            if (retorno == 1)
            {
                MessageBox.Show("La cita fue actualizada exitosamente", "Proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LlenarDataGridInfoCitas();
            }
            else
            {
                MessageBox.Show("La cita no pudo ser actualizada", "Proceso incompleto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
