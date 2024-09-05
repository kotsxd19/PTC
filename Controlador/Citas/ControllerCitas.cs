using Proyecto.Modelo.DAO;
using Proyecto.Vista.InterfazCitas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto.Controlador.Citas
{
    internal class ControllerCitas
    {
        frmCitas objVista;
        public ControllerCitas(frmCitas Vista) 
        {
            objVista = Vista;
            Vista.cmsEliminarCita.Click += new EventHandler(EliminarCita);
            Vista.btnActualizarCita.Click += new EventHandler(ActualizarCita);
            Vista.btnIngresarCita.Click += new EventHandler(IngresarCita);

            void LlenarDataGridCitas()
            {
                DAOCitas daoCitas = new DAOCitas();
                DataSet ds = daoCitas.ObtenerLibros();
                objVista.dgvCitas.DataSource = ds.Tables["ViewStorageBook"];
            }

            void EliminarCita(object sender, EventArgs e)
            {
                int pos = objVista.dgvCitas.CurrentRow.Index;
                DAOCitas daoDelete = new DAOCitas();
                daoDelete.IdCitas1 = int.Parse(objVista.dgvCitas[0, pos].Value.ToString());
                int retorno = daoDelete.EliminarCita();
                if (retorno == 1)
                {
                    MessageBox.Show("La cita seleccionada fue eliminada", "Proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LlenarDataGridCitas()
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("La cita seleccionada no pudo ser eliminada", "Proceso incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
