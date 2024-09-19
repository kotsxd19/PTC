using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Modelo
{
    internal class dbConexion
    {
        public static SqlConnection getConexion()
        {
            try
            {
                //DESKTOP-70UOOD5
                string server = "SQL8020.site4now.net";
                string database = "dbVetManager";
                string user = "db_aad183_vetmanager_admin";
                string pass = "VetManager_2";
                SqlConnection conexion = new SqlConnection("Server =" + server +
                                                                 "; DataBase = " + database + "; User = " + user + "; Password = " + pass);
                conexion.Open();
                return conexion;

            }
            catch (Exception)
            {
                return null;
            }
        }


    }
}
