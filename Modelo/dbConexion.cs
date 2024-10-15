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
        public static SqlConnection getConnection() 
        {
            string server = "SQL8020.site4now.net";
            string database = "db_aad183_vetmanager";
            string userId = "db_aad183_vetmanager_admin";
            string password = "VetManager_2";

            // Cadena de conexión con formato corregido
            string connectionString = $"Server={server};Database={database};User Id={userId};Password={password}";

            try
            {
                // Crear y abrir la conexión
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();

                return conn;
            }
            catch (SqlException ex)
            {
                // Mostrar mensaje de error
                MessageBox.Show($"{ex.Message} Código de error: EC-001 \nNo fue posible conectarse a la base de datos, favor verifique las credenciales o que tenga acceso al sistema.",
                                "Error crítico",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return null;
            }
            catch (Exception ex)
            {
                // Manejo de errores generales
                MessageBox.Show($"{ex.Message} Código de error: EC-002 \nNo se pudo establecer la conexión con la base de datos.",
                                "Error crítico",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return null;
            }
        }

        public static SqlConnection testConnection(string server, string database, string user, string password)
        {
            try
            {
                SqlConnection conexion = new SqlConnection($"Server = {server}; DataBase = {database}; User Id = {user}; Password = {password}");
                conexion.Open();
                return conexion;
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"{ex.Message} Código de error: EC-001 \nNo fue posible conectarse a la base de datos, verifique las credenciales, consulte el manual de usuario.", "Error crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}

