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
        public static SqlConnection getConnection()
        {
            try
            {
                string server = "SQL8020.site4now.net";
                string database = "dbVetManager";
                SqlConnection conexion = new SqlConnection("Server =" + server +
                                                                 "; DataBase = " + database +
                                                                 "; Integrated Security = true");
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
