using Proyecto.Modelo.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Modelo.DAO
{
    internal class DAOAgregarUsuario : DTOAgregarUsuario
    {
        readonly SqlCommand command = new SqlCommand();

        public DataSet LlenarComboBox()
        {
            try
            {
                // Establece la conexión a la base de datos
                command.Connection = getConnection();

                // Consulta SQL para obtener todos los roles
                string query = "SELECT * FROM Roles";
                SqlCommand cmd = new SqlCommand(query, command.Connection);

                // Ejecuta la consulta sin obtener resultados
                cmd.ExecuteNonQuery();

                // Utiliza un SqlDataAdapter para llenar el DataSet con los datos de la consulta
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "Roles");

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

        public int RegistarEmpleados()
        {
            try
            {
                // Establece la conexión a la base de datos
                command.Connection = getConnection();

                // Consulta SQL para insertar un nuevo empleado
                string query2 = "INSERT INTO Empleado VALUES (@Usuario, @Contraseña, @intentos, @IdRole)";
                SqlCommand cmd2 = new SqlCommand(query2, command.Connection);

                // Agrega los parámetros para la consulta de inserción
                cmd2.Parameters.AddWithValue("Usuario", Usuario1);
                cmd2.Parameters.AddWithValue("Contraseña", Contraseña1);
                cmd2.Parameters.AddWithValue("intentos", Intentos);
                cmd2.Parameters.AddWithValue("Roles", Role1);

                // Ejecuta la consulta de inserción y obtiene el número de filas afectadas
                int repuesta = cmd2.ExecuteNonQuery();

                // Si la inserción fue exitosa, realiza otra inserción adicional
                if (repuesta == 1)
                {
                    // Consulta SQL para insertar más detalles del empleado
                    string query = "INSERT INTO Empleado (Usuario, Nombre, Apellido, CorreoEmpleado, FechaNacimient) VALUES (@param1, @param2, @param3, @param4, @param5)";
                    SqlCommand cmd = new SqlCommand(query, command.Connection);
                    cmd.Parameters.AddWithValue("param1", Usuario1);
                    cmd.Parameters.AddWithValue("param2", Nombre1);
                    cmd.Parameters.AddWithValue("param3", Apellido1);
                    cmd.Parameters.AddWithValue("param4", CorreoElectronico1);
                    cmd.Parameters.AddWithValue("param5", FechaNacimiento1);

                    // Ejecuta la consulta de inserción de detalles y obtiene el número de filas afectadas
                    repuesta = cmd.ExecuteNonQuery();

                    // Retorna el resultado de la inserción de detalles
                    return repuesta;
                }
                else
                {
                    // Realiza una reversión si la primera inserción falla
                    RollBack();
                    return 0;
                }
            }
            catch (Exception)
            {
                // Realiza una reversión en caso de error y retorna -1
                RollBack();
                return -1;
            }
            finally
            {
                // Realiza una reversión y cierra la conexión a la base de datos
                RollBack();
                command.Connection.Close();
            }
        }

        public void RollBack()
        {
            // Consulta SQL para eliminar el usuario en caso de un fallo
            string query = "DELETE FROM Empleado WHERE Usuario = @Usuario";
            SqlCommand cmddel = new SqlCommand(query, command.Connection);
            cmddel.Parameters.AddWithValue("Usuario", Usuario1);

            // Ejecuta la consulta de eliminación
            cmddel.ExecuteNonQuery();
        }

        public DataSet ObtenerPersonas()
        {
            try
            {
                // Establece la conexión a la base de datos
                command.Connection = getConnection();

                // Consulta SQL para obtener los empleados activos
                string query = "SELECT * FROM RegistroEmpleado WHERE Usuario = @Usuario";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                cmd.Parameters.AddWithValue("Usuario", true);

                // Ejecuta la consulta sin obtener resultados
                cmd.ExecuteNonQuery();

                // Utiliza un SqlDataAdapter para llenar el DataSet con los datos de la consulta
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds, "RegistroEmpleado");

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

        public int ActualizarEmpleados()
        {
            try
            {
                // Establece la conexión a la base de datos
                command.Connection = getConnection();

                // Consulta SQL para actualizar los detalles del empleado
                string query = "UPDATE Empleado SET " +
                                "Nombre = @param1, " +
                                "Apellido = @param2, " +
                                "FechaNacimient = @param3, " +
                                "CorreoEmpleado = @param4";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                cmd.Parameters.AddWithValue("param1", Nombre1);
                cmd.Parameters.AddWithValue("param2", Apellido1);
                cmd.Parameters.AddWithValue("param3", FechaNacimiento1);
                cmd.Parameters.AddWithValue("param4", CorreoElectronico1);

                // Ejecuta la consulta de actualización y obtiene el número de filas afectadas
                int respuesta = cmd.ExecuteNonQuery();

                // Si la actualización de detalles fue exitosa, actualiza el rol del empleado
                if (respuesta == 1)
                {
                    // Consulta SQL para actualizar el rol del empleado
                    string query2 = "UPDATE Empleado SET " +
                                    "Role = @param9 " +
                                    "WHERE Usuario = @param10";
                    SqlCommand cmd2 = new SqlCommand(query2, getConnection());
                    cmd2.Parameters.AddWithValue("param9", Role1);
                    cmd2.Parameters.AddWithValue("param10", Usuario1);

                    // Ejecuta la consulta de actualización de rol
                    respuesta = cmd2.ExecuteNonQuery();
                    respuesta = 2; // Marca como actualizado correctamente
                }

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

        public int EliminarEmplado()
        {
            try
            {
                // Establece la conexión a la base de datos
                command.Connection = getConnection();

                // Consulta SQL para eliminar al empleado
                string query = "DELETE Empleado WHERE IdEmpleado = @param1";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                cmd.Parameters.AddWithValue("param1", IdEmpleado1);

                // Ejecuta la consulta de eliminación y obtiene el número de filas afectadas
                int respuesta = cmd.ExecuteNonQuery();

                // Si la eliminación fue exitosa, actualiza el estado del usuario
                if (respuesta == 1)
                {
                    string queryupdate = "UPDATE Empleado SET WHERE Usuario = @Usuario";
                    SqlCommand cmdupdate = new SqlCommand(queryupdate, command.Connection);
                    cmdupdate.Parameters.AddWithValue("username", Usuario1);
                    respuesta += cmdupdate.ExecuteNonQuery();
                }

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


        public DataSet BuscarPersonas(string valor)
        {
            try
            {
                //Accedemos a la conexión que ya se tiene
                command.Connection = getConnection();
                //Instrucción que se hará hacia la base de datos
                string query = $"SELECT * FROM Empleados WHERE Nombres LIKE '%{valor}%' OR Usuario LIKE '%{valor}%' OR [Rol de acceso] LIKE '%{valor}%'";
                //Comando sql en el cual se pasa la instrucción y la conexión
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                //Se ejecuta el comando y con ExecuteNonQuery se verifica su retorno
                //ExecuteNonQuery devuelve un valor entero.
                cmd.ExecuteNonQuery();
                //Se utiliza un adaptador sql para rellenar el dataset
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                //Se crea un objeto Dataset que es donde se devolverán los resultados
                DataSet ds = new DataSet();
                //Rellenamos con el Adaptador el DataSet diciendole de que tabla provienen los datos
                adp.Fill(ds, "Empelado");
                //Devolvemos el Dataset
                return ds;
            }
            catch (Exception)
            {
                //Retornamos null si existiera algún error durante la ejecución
                return null;
            }
            finally
            {
                //Independientemente se haga o no el proceso cerramos la conexión
                getConnection().Close();
            }
        }
    }
}
