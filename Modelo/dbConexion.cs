﻿using System;
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
                string server = "DESKTOP-70UOOD5\\SQLEXPRESS01";
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
