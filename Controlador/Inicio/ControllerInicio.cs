using Proyecto.Controlador.Validar;
using Proyecto.Vista.AgregarUsuarios;
using Proyecto.Vista.Inicio;
using Proyecto.Vista.Login;
using Proyecto.Vista.Proveedor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto.Controlador.Inicio
{
    internal class ControllerInicio
    {
        frmInicio objVista;
        Form currentForm = null;

        public ControllerInicio(frmInicio Vista)
        {
            objVista = Vista;
            Vista.Load += new EventHandler(CargarDatos);
            Vista.btnEmpleados.Click += new EventHandler(openFormEmpleados);
            Vista.btnProveedor.Click += new EventHandler(openFromProveedor);
        }

        void CargarDatos(object sender, EventArgs e)
        {
            objVista.lblUserConnected.Text = Acceso.Usuario;
            objVista.lblAccessUser.Text = Acceso.RoleId;
            objVista.lblNameEmployee.Text = Acceso.Nombre;
        }

        void openFormEmpleados(object sender, EventArgs e)
        {
            AbrirFormulario<frmRegistroUsuario>();
        }

        void openFromProveedor(object sender, EventArgs e)
        {
            AbrirFormulario<frmProveedor>();
        }

        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            //Se declara objeto de tipo Form llamada formulario
            Form formulario;
            //Se guarda en el panel contenedor del formulario principal todos los controles del formulario que desea abrir <MiForm> posteriormente se guarda todo en el objeto de tipo formulario
            formulario = objVista.PanelContenedor.Controls.OfType<MiForm>().FirstOrDefault();
            //Si el formulario no existe se procederá a crearlo de lo contrario solo se traerá al frente (ver clausula else)
            if (formulario == null)
            {
                //Se define un nuevo formulario para guardarse como nuevo objeto MiForm
                formulario = new MiForm();
                //Se especifica que el formulario debe mostrarse como ventana
                formulario.TopLevel = false;
                //Se eliminan los bordes del formulario
                formulario.FormBorderStyle = FormBorderStyle.None;
                //Se establece que se abrira en todo el espacio del formulario padre
                formulario.Dock = DockStyle.Fill;
                //Se le asigna una opacidad de 0.75
                formulario.Opacity = 0.75;
                //Se evalua el formulario actual para verificar si es nulo
                if (currentForm != null)
                {
                    //Se cierra el formulario actual para mostrar el nuevo formulario
                    currentForm.Close();
                    //Se eliminan del panel contenedor todos los controles del formulario que se cerrará
                    objVista.PanelContenedor.Controls.Remove(currentForm);
                }
                //Se establece como nuevo formulario actual el formulario que se está abriendo
                currentForm = formulario;
                //Se agregan los controles del nuevo formulario al panel contenedor
                objVista.PanelContenedor.Controls.Add(formulario);
                //Tag es una propiedad genérica disponible para la mayoría de los controles en aplicaciones .NET, incluyendo los paneles.
                objVista.PanelContenedor.Tag = formulario;
                //Se muestra el formulario en el panel contenedor
                formulario.Show();
                //Se trae al frente el formulario armado
                formulario.BringToFront();
            }
            else
            {
                formulario.BringToFront();
            }
        }

        private void CerrarForm(object sender, EventArgs e)
        {
            if (currentForm != null)
            {
                //Se cierra el formulario actual para mostrar el nuevo formulario
                currentForm.Close();
                //Se eliminan del panel contenedor todos los controles del formulario que se cerrará
                objVista.PanelContenedor.Controls.Remove(currentForm);
            }
        }
    }
}
