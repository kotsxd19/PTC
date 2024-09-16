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
            vista.ptcCorreo.Click += new EventHandler(RecuperacionPorCorreo);
            vista.pctPreguntasSeguridad.Click += new EventHandler(RecuperacionPorPreguntasSeguridad);
            vista.ptcReinicioDirecto.Click += new EventHandler(RecuperacionPorReinicioDirecto);
            vista.ptcIntervesionAdmin.Click += new EventHandler(RecuperacionPorAdmin);
           
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


    }
}
