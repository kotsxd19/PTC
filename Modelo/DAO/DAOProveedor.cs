using Proyecto.Modelo.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Modelo.DAO
{
    internal class DAOProveedor : DTOProveedor
    {

        SqlCommand command = new SqlCommand();

        public int RegistarProveedor()
        {


            try
            {
                // Establece la conexión a la base de datos
                command.Connection = getConnection();

                // Consulta SQL para insertar más detalles del empleado
                string query = "INSERT INTO Proveedor VALUES (@param1)";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                cmd.Parameters.AddWithValue("param1", Proveedor);

                int respuesta = cmd.ExecuteNonQuery();

                return respuesta;
                //}
            }
            catch (Exception ex)
            {
                // Realiza una reverdsión en caso de error y retorna -1
                RollBack();
                return -1;
            }
            finally
            {
                // Realiza una reversión y cierra la conexión a la base de datos

                command.Connection.Close();
            }
        }

        public void RollBack()
        {
            // Consulta SQL para eliminar el usuario en caso de un fallo
            string query = "DELETE FROM Proveedor WHERE Proveedor = @Proveedor";
            SqlCommand cmddel = new SqlCommand(query, command.Connection);
            cmddel.Parameters.AddWithValue("Usuario", Proveedor);

            // Ejecuta la consulta de eliminación
            cmddel.ExecuteNonQuery();
        }

        public int ActualizarProveedor()
        {
            try
            {
                // Establece la conexión a la base de datos
                command.Connection = getConnection();

                // Consulta SQL para actualizar los detalles del empleado
                string query = "UPDATE Proveedor SET " +
                                "Nombre = @param1, ";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                cmd.Parameters.AddWithValue("param1", Proveedor);

                // Ejecuta la consulta de actualización y obtiene el número de filas afectadas
                int respuesta = cmd.ExecuteNonQuery();

                // Retorna el resultado de la actualización
                return respuesta;
            }
            catch (Exception)
            {
                // Retorna -1 en caso de error
                return -1;
            }
            finally
            {
                // Cierra la conexión a la base de datos
                getConnection().Close();
            }
        }

        public int EliminarProveedor()
        {
            try
            {
                // Establece la conexión a la base de datos 
                command.Connection = getConnection();

                // Consulta SQL para eliminar al empleado
                string query = "DELETE Proveedor WHERE IdProveedor = @param0";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                cmd.Parameters.AddWithValue("param0", IdProveedor1);

                // Ejecuta la consulta de eliminación y obtiene el número de filas afectadas
                int respuesta = cmd.ExecuteNonQuery();

                // Retorna el resultado de la eliminación
                return respuesta;
            }
            catch (Exception)
            {
                // Retorna -1 en caso de error
                return -1;
            }
            finally
            {
                // Cierra la conexión a la base de datos
                getConnection().Close();
            }
        }
    }
}
