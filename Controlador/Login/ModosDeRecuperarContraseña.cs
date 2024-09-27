using Proyecto.Vista.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Controlador.Login
{
    internal class ModosDeRecuperarContraseña
    {
        frmRecuperacioneDeContra vista;
       

        public ModosDeRecuperarContraseña(frmRecuperacioneDeContra vista)
        {
            this.vista = vista;
            vista.btnCorreoElectronico.Click += new EventHandler(RecuperacionPorCorreo);
            vista.btnPreguntasSeguridad.Click += new EventHandler(RecuperacionPorPreguntasSeguridad);
            vista.btnRegresar.Click += new EventHandler(Atras);
        }

        void RecuperacionPorCorreo(object sender, EventArgs e)
        {
            frmRecuperacionContraCorreo AbrirFormulario = new frmRecuperacionContraCorreo();
            AbrirFormulario.ShowDialog();
        }

        void RecuperacionPorPreguntasSeguridad(object sender, EventArgs e)
        {
            frmRecuperarContraseñaPreguntas AbrirFormulario = new frmRecuperarContraseñaPreguntas();
            AbrirFormulario.ShowDialog();
        }

        void RecuperacionPorReinicioDirecto(object sender, EventArgs e)
        {
            frmRecuperarContraseñaReinicioDirectoAdmin AbrirFormulario = new frmRecuperarContraseñaReinicioDirectoAdmin();
            AbrirFormulario.ShowDialog();
        }

        void RecuperacionPorAdmin(object sender, EventArgs e)
        {
            frmRecuperarContraseñaAdmin AbrirFormulario = new frmRecuperarContraseñaAdmin();
            AbrirFormulario.ShowDialog();
        }

        void Atras(object sender, EventArgs e)
        {
           frmLogin ArbirLogin = new frmLogin();
            ArbirLogin.ShowDialog();
            vista.Close();
        }
    }
}
