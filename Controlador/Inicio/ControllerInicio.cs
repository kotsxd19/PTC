using Proyecto.Controlador.Validar;
using Proyecto.Vista.Inicio;
using Proyecto.Vista.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Controlador.Inicio
{
    internal class ControllerInicio
    {
        frmInicio objVista;
        
        public ControllerInicio(frmInicio Vista)
        {
            objVista = Vista;
            Vista.Load += new EventHandler(CargarDatos);
        }

        void CargarDatos(object sender, EventArgs e)
        {
            objVista.lblUserConnected.Text = Acceso.Usuario;
            objVista.lblAccessUser.Text = Acceso.RoleId;
            objVista.lblNameEmployee.Text = Acceso.Nombre;
        }

    }
}
