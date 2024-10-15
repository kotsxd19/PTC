using Proyecto.Modelo.DAO;
using Proyecto.Modelo;
using Proyecto.Vista.Mascota;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto.Vista.Proveedor;

namespace Proyecto.Controlador.Mascota
{
    internal class ControllerMascota
    {
        frmMascota objMascota;

        public ControllerMascota(frmMascota vista)
        {
            objMascota = vista;
            objMascota.Load += new EventHandler(CargaDGV);
            objMascota.btnNuevaMascota.Click += new EventHandler(RegistrarPropietario);
            objMascota.btnActualizarMascota.Click += new EventHandler(ActualizarRegistro);
        }
        public void CargaDGV(object sender, EventArgs e)
        {
            RefreshData();
        }
        public void RefreshData()
        {
            DAOPropietario dao = new DAOPropietario();
            DataSet ds = dao.LLenarDGV();
            objMascota.dgvMascotas.DataSource = ds.Tables["Mascota"];
        }

        private void RegistrarPropietario(object sender, EventArgs e)
        {
            frmAgregarMascota frm = new frmAgregarMascota(1);
            frm.ShowDialog();
            RefreshData(); 
        }

        private void ActualizarRegistro(object sender, EventArgs e)
        {
            int pos = objMascota.dgvMascotas.CurrentRow.Index; // Obtiene la posición de la fila seleccionada en el DataGridView

            // Crea una nueva instancia del formulario para editar usuario con la acción de actualización
            frmAgregarMascota openForm = new frmAgregarMascota(2);

            // Enviar los datos de la fila seleccionada al formulario de edición
            int.Parse(objMascota.dgvMascotas[0, pos].Value.ToString());
            objMascota.dgvMascotas[1, pos].Value.ToString();

            openForm.ShowDialog(); // Muestra el formulario como un diálogo modal
            RefreshData(); // Refresca los datos en el DataGridView después de cerrar el formulario
        }
        
    }
}
