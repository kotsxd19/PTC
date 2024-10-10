using Proyecto.Modelo.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Modelo.DAO
{
    internal class DAOCitas : DTOCitas
    {
        SqlCommand command = new SqlCommand();

        public DataSet LlenarComboBoxEmpleado()
        {
            try
            {
                // Establece la conexión a la base de datos
                command.Connection = getConnection();

                // Consulta SQL para obtener todos los roles
                string query = "SELECT * FROM Empleados";
                SqlCommand cmd = new SqlCommand(query, command.Connection);

                // Ejecuta la consulta sin obtener resultados
                cmd.ExecuteNonQuery();

                // Utiliza un SqlDataAdapter para llenar el DataSet con los datos de la consulta
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "Empleado");

                // Retorna el DataSet con los roles
                return ds;
            }
            catch (Exception)
            {
                // Retorna null si ocurre una excepción
                return null;
            }
            finally
            {
                // Cierra la conexión a la base de datos independientemente de si ocurre una excepción o no
                getConnection().Close();
            }
        }

        public DataSet ObtenerMascota()
        {
            try
            {
                // Establece la conexión a la base de datos
                command.Connection = getConnection();

                // Consulta SQL para obtener los empleados activos
                string query = "SELECT * FROM Mascota";
                SqlCommand cmd = new SqlCommand(query, command.Connection);

                // Ejecuta la consulta sin obtener resultados
                cmd.ExecuteNonQuery();

                // Utiliza un SqlDataAdapter para llenar el DataSet con los datos de la consulta
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds, "Mascota");

                // Retorna el DataSet con los empleados activos
                return ds;
            }
            catch (Exception)
            {
                // Retorna null si ocurre una excepción
                return null;
            }
            finally
            {
                // Cierra la conexión a la base de datos independientemente de si ocurre una excepción o no
                getConnection().Close();
            }
        }
        public int RegistarCitas()
        {
            try
            {
                // Establece la conexión a la base de datos
                command.Connection = getConnection();

                // Consulta SQL para insertar más detalles del empleado
                string query = "INSERT INTO Citas VALUES (@param1, @param2, @param3, @param4, @param5)";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                cmd.Parameters.AddWithValue("param1", IdEmpleado1);
                cmd.Parameters.AddWithValue("param2", IdMascota1);
                cmd.Parameters.AddWithValue("param3", Fecha1);
                cmd.Parameters.AddWithValue("param4", Hora1);
                cmd.Parameters.AddWithValue("param5", Descripcion1);
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
            string query = "DELETE FROM Citas WHERE IdCitas = @IdCitas";
            SqlCommand cmddel = new SqlCommand(query, command.Connection);
            cmddel.Parameters.AddWithValue("IdCitas", IdCitas1);

            // Ejecuta la consulta de eliminación
            cmddel.ExecuteNonQuery();
        }


    }
}
