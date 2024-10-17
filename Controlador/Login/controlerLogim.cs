using Proyecto.Modelo.DAO;
using Proyecto.Vista.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto.Controlador.Validar;
using Proyecto.Vista.AgregarUsuarios;
using Proyecto.Vista.Inicio;
using System.Runtime.Remoting.Contexts;
using Proyecto.Modelo;

namespace Proyecto.Controlador.Login
{
    internal class controlerLogim
    {
        public class ControladorLogin
         {
            frmLogin ObjLogin;

            /// <summary>
            /// Constructor de la clase ControladorLogin que inicia los eventos de la vista
            /// </summary>
            /// <param name="Vista"></param>

            public ControladorLogin(frmLogin Vista)
            {
                ObjLogin = Vista;

                ObjLogin.btnIngresar.Click += new EventHandler(AccesoAlosDatos);

                ObjLogin.txtUsuario.Enter += new EventHandler(IngresarUsuario);
                ObjLogin.txtUsuario.Leave += new EventHandler(dejarUsuario);

                ObjLogin.btnModosRecuperarContraseña.Click += new EventHandler(ModosDeRecuperarContraseñas);
                ObjLogin.btnComrpobarConexion.Click += new EventHandler(ComprobarConexion);

                ObjLogin.txtContraseña.Enter += new EventHandler(IngresarContra);
                ObjLogin.txtContraseña.Leave += new EventHandler(DejarContra);
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            /// 
            

            /// <summary>
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            /// 


            void ModosDeRecuperarContraseñas(object sender, EventArgs e)
            {
                frmRecuperacioneDeContra AbrirFromularios = new frmRecuperacioneDeContra();
                AbrirFromularios.Show();
                ObjLogin.Hide();
            }

            private void AccesoAlosDatos(object sender, EventArgs e)
            {
                DAOLogin DAOData = new DAOLogin();
                Incriptar common = new Incriptar();

                DAOData.Usuario1 = ObjLogin.txtUsuario.Text;
                DAOData.Contraseña1 = common.ComputeSha256Hash(ObjLogin.txtContraseña.Text);
                //string password = "123456";
                string hashedPassword = common.ComputeSha256Hash(ObjLogin.txtContraseña.Text);
                MessageBox.Show("Hash de la contraseña '444': " + hashedPassword);

                DAOData.Usuario1 = ObjLogin.txtUsuario.Text;
                DAOData.Contraseña1 = common.ComputeSha256Hash(ObjLogin.txtContraseña.Text);

                // Asignar valores a DAOData
                DAOData.Usuario1 = ObjLogin.txtUsuario.Text;
                DAOData.Contraseña1 = common.ComputeSha256Hash(ObjLogin.txtContraseña.Text);

                if (ObjLogin.txtContraseña.Text.Length < 100 && ObjLogin.txtUsuario.Text.Length < 100)
                {
                    
                    // Verificar autenticación

                    bool isAuthenticated = DAOData.Login();
                   
                    if (isAuthenticated)
                    {
                        // Verificar condición adicional para recuperación de contraseña
                        if (ObjLogin.txtContraseña.Text.Trim() == ObjLogin.txtUsuario.Text.Trim() /*+ "PU123"*/)
                        {
                            frmRecuperacioneDeContra openForm = new frmRecuperacioneDeContra();
                            openForm.Show();
                        }
                        else
                        {
                            // Autenticación exitosa, mostrar la ventana principal
                            ObjLogin.Hide();
                            frmInicio viewDashboard = new frmInicio();
                            viewDashboard.Show();
                        }
                    }
                    else
                    {
                        // Autenticación fallida Datos incorrectos + DAOData.Contraseña1 + DAOData.Contraseña1
                        MessageBox.Show($"Datos incorrectos {DAOData.Usuario1},{DAOData.Contraseña1}", "Error al iniciar sesión", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Pasastes el maximo de caracteristicas", "Error de capacidad", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


            private void IngresarUsuario(object sender, EventArgs e)
            {
                if (ObjLogin.txtContraseña.Text.Length < 100 || ObjLogin.txtUsuario.Text.Length < 100)
                {
                    if (ObjLogin.txtUsuario.Text.Trim().Equals("Usuario"))
                    {
                        ObjLogin.txtUsuario.Clear();
                        ObjLogin.txtUsuario.Visible = true;
                    }
                }
                else
                {
                    MessageBox.Show("Pasastes el maximo de caracteristicas", "Error de capacidad", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            


            private void dejarUsuario(object sender, EventArgs e)
            {   

                if (ObjLogin.txtUsuario.Text.Trim().Equals(""))
                {
                    ObjLogin.txtUsuario.Text = "Usuario";
                }
            }




            /// <summary>
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            /// 

            private void IngresarContra(object sender, EventArgs e)
            {
                if (ObjLogin.txtContraseña.Text.Trim().Equals("Contraseña"))
                {
                    ObjLogin.txtContraseña.Clear();
                    ObjLogin.txtContraseña.UseSystemPasswordChar = true;
                }
            }


            /// <summary>
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void DejarContra(object sender, EventArgs e)
            {
                if (ObjLogin.txtContraseña.Text.Trim().Equals(""))
                {
                    ObjLogin.txtContraseña.Text = "Contraseña";
                    ObjLogin.txtContraseña.PasswordChar = '\0';
                }
            }

            private void ComprobarConexion(object sender, EventArgs e)
            {
                //Se hace referencia a la clase dbContext y su método getConnection y se evalúa
                // si el retorno es nulo o no, en caso de ser nulo se mostrará el primer mensaje
                //de lo contrario se mostrará el código del segmento else.
                if (dbConexion.getConnection() == null)
                {
                    MessageBox.Show("No fue posible realizar la conexión al servidor y/o la base de datos.", "Conexión fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    MessageBox.Show("La conexión al servidor y la base de datos se ha ejecutado correctamente.", "Conexión exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }


            /// <summary>
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            /// 

            private void QuitarVentana(object sender, EventArgs e)
            {
                Application.Exit();
            }

        }
    }
}
