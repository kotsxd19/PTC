using Proyecto.Controlador.Validar;
using Proyecto.Vista.PrimerUso;
using Proyecto.Vista.Servidor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto.Controlador.Servidor
{
    internal class ControllerConfrimarContraseña
    {
        frmConfrimarContraseña objVista;
        private string usuario;

        public ControllerConfrimarContraseña(frmConfrimarContraseña vista, string usuario)
        {
            objVista = vista;
            this.usuario = usuario;
            objVista.btnConfirmar.Click += new EventHandler(VerificarContraseña);
        }

        public void VerificarContraseña(object sender, EventArgs e)
        {
            Incriptar common = new Incriptar();
            //Utilizando el objeto DAO para invocar a los metodos getter y setter del DTO
            string cadenaencriptada = common.ComputeSha256Hash(objVista.txtContraseña.Text);
            if (cadenaencriptada == Acceso.Contraseña)
            {
                frmConexionAdministrador objViewConnect = new frmConexionAdministrador();
                objViewConnect.ShowDialog();
                objVista.Hide();
            }
            else
            {
                MessageBox.Show("Acceso denegado, las credenciales no tienen los permisos suficientes.", "Error al validar contraseña", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
