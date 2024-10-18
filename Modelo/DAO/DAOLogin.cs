using Proyecto.Controlador.Validar;
using Proyecto.Modelo.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Proyecto.Modelo.DAO
{
    internal class DAOLogin : DTOLogin
    {
        SqlCommand Command = new SqlCommand();

        public bool Login()
        {
            try
            {
                // Establece la conexión a la base de datos utilizando el método getConnection
                Command.Connection = getConnection();

                // Define la consulta SQL para buscar un usuario con las credenciales proporcionadas
                string query = $"SELECT * FROM ViewLogin WHERE Usuario = '{Usuario1}' AND Contraseña = '{Contraseña1}'";
                SqlCommand cmd = new SqlCommand(query, Command.Connection);

                // Agrega los parámetros a la consulta SQL para evitar inyecciones de SQL
                //cmd.Parameters.AddWithValue("Usuario", Usuario1);
                //cmd.Parameters.AddWithValue("Contraseña", Contraseña1);

                // Ejecuta la consulta y obtiene un SqlDataReader para leer los resultados
                SqlDataReader rd = cmd.ExecuteReader();

                // Lee los resultados de la consulta
                while (rd.Read())
                {
                    // Asigna los valores leídos a la clase de acceso
                    Acceso.Usuario = rd.GetString(0); // Suponiendo que el primer campo es el Usuario
                    Acceso.Nombre = rd.GetString(2); // Suponiendo que el sexto campo es el Nombre
                    Acceso.Contraseña = rd.GetString(1); // Suponiendo que el segundo campo es la Contraseña
                    Acceso.RoleId = rd.GetString(4); // Suponiendo que el cuarto campo es el RoleId
                    //Acceso.Access = rd.GetString(4); // Suponiendo que el quinto campo es el Access
                    
                }

                // Retorna true si se encontraron filas que coinciden con la consulta
                return rd.HasRows;
            }
            catch (SqlException sqlex)
            {
                // Muestra un mensaje de error si ocurre una excepción SQL
                MessageBox.Show(sqlex.Message);
                return false;
            }
            catch (Exception ex)
            {
                // Muestra un mensaje de error para cualquier otra excepción
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                // Cierra la conexión a la base de datos en el bloque finally para asegurar que siempre se cierre
                getConnection().Close();
            }
        }


        public int PrimerUso()
        {
            try
            {
                Command.Connection = getConnection();
                string query = "SELECT COUNT(*) FROM Empleado";
                SqlCommand cmd = new SqlCommand(query, Command.Connection);
                int UsuariosTotal = (int)cmd.ExecuteScalar();
                return UsuariosTotal;
            }
            catch (SqlException sqlex)
            {
                MessageBox.Show(sqlex.Message);
                return -1; ;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return -1;
            }
            finally
            {
                getConnection().Close();
            }
        }
    }
}
