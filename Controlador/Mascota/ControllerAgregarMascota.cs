using Proyecto.Vista.Mascota;
using System;
using System.Collections.Generic;
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
            objMascota.btnActualizarMascotas.Click += new EventHandler(ActualizarRegistro);
        }

        private void RegistrarMascota(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(objMascota.txtNombre.Text.Trim()) || string.IsNullOrEmpty(objMascota.cmbGenero.Text.Trim()) || string.IsNullOrEmpty(objMascota.txtDueño.Text.Trim()) || string.IsNullOrEmpty(objMascota.txtPeso.Text.Trim())))
            {
                DAOMascota daoinsert = new DAOMascota();
                daoinsert.Nombre = objMascota.txtNombre.Text.Trim();
                daoinsert.Genero = objMascota.txtGenero.Text.Trim();
                daoinsert.Dueño = objMascota.txtDueño.Text.Trim();
                daoinsert.Peso = objMascota.txtPeso.Text.Trim();
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
