using Proyecto.Vista.AgregarMascotas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 
using Proyecto.Modelo.DAO;
using Proyecto.Modelo.DTO;
namespace Proyecto.Controlador.Mascota
{
    internal class AgregarMascotaController
    {
        FrmAgregarMascota ObjMascota;
        //Eventos
        public AgregarMascotaController(FrmAgregarMascota vista)
        {
            ObjMascota = vista;
            vista.txtDueño.KeyPress += new KeyPressEventHandler(SoloLetras);
            vista.txtNombre.KeyPress += new KeyPressEventHandler(SoloLetras);
            vista.txtRaza.KeyPress += new KeyPressEventHandler(SoloLetras);
            vista.txtPeso.KeyPress += new KeyPressEventHandler(SoloNumeros);
        }
        //solo letras
        private void SoloLetras(object sender, KeyPressEventArgs e)
        {
            // Permitir solo letras y un único espacio
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }
        //solo numeros
        private void SoloNumeros(object sender, KeyPressEventArgs e)
        {
            // Permitir solo números y la tecla de retroceso
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}
