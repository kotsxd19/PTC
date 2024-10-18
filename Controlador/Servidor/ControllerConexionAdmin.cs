using Proyecto.Modelo;
using Proyecto.Modelo.DTO;
using Proyecto.Vista.PrimerUso;
using Proyecto.Vista.Servidor;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Proyecto.Controlador.Servidor
{
    internal class ControllerConexionAdmin
    {
        frmAdminConexion ObjAdmin;
        int origen;

        public ControllerConexionAdmin(frmAdminConexion View/* int origen*/)
        {
            ObjAdmin = View;
            //verificarOrigen(origen);
            ///tabcontrol 2
            View.btnConfirmar.Click += new EventHandler(GuardarRegistro);

        }

        public void verificarOrigen(int origen)
        {
            if (origen == 2)
            {
                //Cambiar configuración
                ObjAdmin.txtServidorURL.Text = DTOdbContext.Servidor1;
                ObjAdmin.txtBaseDeDatos.Text = DTOdbContext.BaseDatos1;
                ObjAdmin.txtSQAurhentication.Text = DTOdbContext.Usuario1;
                ObjAdmin.txtContraseñaAurhentication.Text = DTOdbContext.Contraseña1;
            }
        }


        void GuardarRegistro(object sender, EventArgs e)
        {
            GuardarConfiguracionXML();
        }
        public void GuardarConfiguracionXML()
        {
            try
            {
                //Se define que tipo de documento se va a crear
                XmlDocument doc = new XmlDocument();

                //Crear declaración XML
                XmlDeclaration decl = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
                doc.AppendChild(decl);

                //Crear elemento raíz
                XmlElement root = doc.CreateElement("Conn");
                doc.AppendChild(root);

                //Crear los elementos hijos y agregarlos al elemento raíz
                XmlElement servidor = doc.CreateElement("Server");
                string servidorCode = CodificarBase64String(ObjAdmin.txtServidorURL.Text.Trim());
                servidor.InnerText = servidorCode;
                root.AppendChild(servidor);

                XmlElement Database = doc.CreateElement("Database");
                string DatabaseCode = CodificarBase64String(ObjAdmin.txtBaseDeDatos.Text.Trim());
                Database.InnerText = DatabaseCode;
                root.AppendChild(Database);


                SqlConnection con = dbConexion.testConnection(ObjAdmin.txtServidorURL.Text.Trim(), ObjAdmin.txtBaseDeDatos.Text.Trim(), ObjAdmin.txtSQAurhentication.Text.Trim(), ObjAdmin.txtContraseñaAurhentication.Text.Trim());
                if (con != null)
                {
                    doc.Save("config_server.xml");
                    DTOdbContext.Servidor1 = ObjAdmin.txtServidorURL.Text.Trim();
                    DTOdbContext.BaseDatos1 = ObjAdmin.txtBaseDeDatos.Text.Trim();
                    DTOdbContext.Usuario1 = ObjAdmin.txtSQAurhentication.Text.Trim();
                    DTOdbContext.Contraseña1 = ObjAdmin.txtContraseñaAurhentication.Text.Trim();
                    MessageBox.Show($"El archivo fue creado exitosamente.", "Archivo de configuración", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ObjAdmin.Dispose();
                }

            }
            catch (XmlException ex)
            {
                MessageBox.Show($"{ex.Message}, no se pudo crear el archivo de configuración.", "Consulte el manual técnico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public string CodificarBase64String(string textoacifrar)
        {
            try
            {
                byte[] bytes = Encoding.UTF8.GetBytes(textoacifrar);
                //Codificación base 64 string
                string base64String = Convert.ToBase64String(bytes);
                return base64String;
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }

    }
}
