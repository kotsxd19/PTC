using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto.Modelo
{
    internal class dbConexion
    {   
        private string server; private string database; private string user; private string password; public string Server { get => server; set => server = value; }
        public string Database { get => database; set => database = value; }
        public string User { get => user; set => user = value; }
        public string Password { get => password; set => password = value; }
        public static SqlConnection getConnection() 
        { 
            try 
            { string server = "SQL8020.site4now.net";
                string database = "db_aad183_vetmanager";
                string userId = "db_aad183_vetmanager_admin";
                string Password = "VetManager_2";
                SqlConnection conn = new SqlConnection($"Server = {server}; DataBase = {database}; User Id = {userId}; Password = {Password}");
                conn.Open(); return conn; 
            }
            catch (SqlException ex) { MessageBox.Show($"{ex.Message} Código de error: EC-001 \nNo fue posible conectarse a la base de datos, favor verifique las credenciales o que tenga acceso al sistema.", "Error crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null; 
            }
        }
    }
}

