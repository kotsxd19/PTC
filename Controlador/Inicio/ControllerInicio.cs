using Proyecto.Controlador.Validar;
using Proyecto.Vista.AgregarUsuarios;
using Proyecto.Vista.Inicio;
using Proyecto.Vista.Login;
using Proyecto.Vista.Mascota;
using Proyecto.Vista.Proveedor;
using Proyecto.Vista.Ventas;
using Proyecto.Vista.Dueño;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto.Vista.citas;
using Proyecto.Vista.Producto;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Proyecto.Vista.Servidor;

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
            Vista.Load += new EventHandler(EventosIniciales);
            Vista.btnEmpleados.Click += new EventHandler(openFormEmpleados);
            Vista.btnProveedor.Click += new EventHandler(openFromProveedor);
            Vista.btnVentas.Click += new EventHandler(openFromVentas);
            Vista.btnClientes.Click += new EventHandler(openFromClientes);
            Vista.btnMascotas.Click += new EventHandler(openFromMascotas);
            Vista.btnCitas.Click += new EventHandler(openFromCitas);
            Vista.btnProducto.Click += new EventHandler(openFromProducto);
            Vista.gestiónDeEmpleadToolStripMenuItem.Click += new EventHandler(openFormEmpleados);
            Vista.mascotsToolStripMenuItem.Click += new EventHandler(openFromMascotas);

            Vista.cerrarFormularioToolStripMenuItem.Click += new EventHandler(CerrarForm);
            //Vista.btnce += new EventHandler(Logout);
        }


        void EventosIniciales(object sender, EventArgs e)
        {
            AccesoRoles();
        }

        /// <summary>
        /// El metodo acceso determina que accesos tendrá disponibles el usuario cuando inicie sesión.
        /// </summary>
        public void AccesoRoles()
        {
            //Estructura selectiva para evaluar los posibles valores de la vraible Access
            switch (Acceso.Access)
            {
                case "admin":
                    break;
                case "Recepcionista":
                    objVista.btnEmpleados.Visible = false;
                    objVista.btnVentas.Visible = false;
                    break;
                case "Veterinario":
                    objVista.btnEmpleados.Visible = false;
                    objVista.btnVentas.Visible = false;
                    break;
                case "Conserje":
                    objVista.btnEmpleados.Visible = false;
                    objVista.btnVentas.Visible = false;
                    objVista.btnCitas.Visible = false;
                    objVista.btnClientes.Visible = false;
                    objVista.btnProveedor.Visible = false;
                    objVista.btnMascotas.Visible = false;
                    break;
                case "Enfermero":
                    objVista.btnEmpleados.Visible = false;
                    objVista.btnVentas.Visible = false;
                    break ;
                default:
                    break;
            }
        }


        public void ConfServer(object sender, EventArgs e)
        {
            frmConfrimarContraseña objview = new frmConfrimarContraseña();
            objview.ShowDialog();
        }

        void CargarDatos(object sender, EventArgs e)
        {
            objVista.lblUserConnected.Text = Acceso.Usuario;
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

        void openFromVentas(object sender, EventArgs e)
        {
            AbrirFormulario<frmVentas>();
        }

        void openFromClientes(object sender, EventArgs e)
        {
            AbrirFormulario<frmDueño>();
        }

        void openFromMascotas(object sender, EventArgs e)
        {
            AbrirFormulario<frmMascota>();
        }

        void openFromCitas(object sender, EventArgs e)
        {
            AbrirFormulario<frmAgregarCitas>();
        }

        void openFromProducto(object sender, EventArgs e)
        {
            AbrirFormulario<frmProducto>();
        }


        private void Logout(Object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cerrar sesión?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LimpiarVariablesSesion();
                frmLogin backForm = new frmLogin();
                backForm.Show();
                objVista.Dispose();
            }
        }

        void LimpiarVariablesSesion()
        {
            Acceso.Usuario = string.Empty;
            Acceso.Contraseña = string.Empty;
            Acceso.Nombre = string.Empty;
            Acceso.Access = string.Empty;
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
