using Proyecto.Modelo.DAO;
using Proyecto.Vista.Mascota;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto.Controlador.Mascota
{
    internal class ControllerAgregarMascota
    {
        frmAgregarMascota objMascota;

        public ControllerAgregarMascota(frmAgregarMascota objMascota)
        {
            this.objMascota = objMascota;
            objMascota.btnIngresarMascotas.Click += new EventHandler(RegistrarMascota);
            //objMascota.btnActualizarMascotas.Click += new EventHandler(ActualizarRegistro);
        }

        public void CargaDGV(object sender, EventArgs e)
        {
            RefreshData();
        }
        public void RefreshData()
        {
            DAOPropietario dao = new DAOPropietario();
            //objMascota.dataGridView2.DataSource = ds.Tables["Mascota"];
        }

        private void RegistrarMascota(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(objMascota.txtNombre.Text.Trim()) || string.IsNullOrEmpty(objMascota.cmbGenero.Text.Trim()) || string.IsNullOrEmpty(objMascota.dgvDueño.Text.Trim()) || string.IsNullOrEmpty(objMascota.nudPeso.Text.Trim())))
            {
                DAOMascotas daoinsert = new DAOMascotas();
                daoinsert.Nombre = objMascota.txtNombre.Text.Trim();
                daoinsert.Genero = objMascota.cmbGenero.Text.Trim();
                daoinsert.Dueño = objMascota.dgvDueño.Text.Trim();
                daoinsert.Peso = objMascota.nudPeso.Text.Trim();
                int valorretornado = daoinsert.RegistrarMascota();
                if (valorretornado == 1)
                {
                    MessageBox.Show("Registro ingresado exitosamente", "Proceso completado con exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshData();
                }
                else
                {
                    MessageBox.Show("El registro no se pudo ingresar", "Proceso incompleto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Existen campos vacios obligatorios", "Proceso interrumpido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


    }
}
