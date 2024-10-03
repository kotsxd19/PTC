﻿using Proyecto.Modelo.DTO;
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

        public DataSet ObtenerPersonasActivas()
        {
            try
            {
                //Accedemos a la conexión que ya se tiene
                command.Connection = getConnection();
                //Instrucción que se hará hacia la base de datos
                string query = "SELECT * FROM RegsitrosDeEmpleados WHERE EstadoEmpleado = @True";
                //Comando sql en el cual se pasa la instrucción y la conexión
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                //Asignando valor al parametro
                cmd.Parameters.AddWithValue("valor", true);
                //Se ejecuta el comando y con ExecuteNonQuery se verifica su retorno
                //ExecuteNonQuery devuelve un valor entero.
                cmd.ExecuteNonQuery();
                //Se utiliza un adaptador sql para rellenar el dataset
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                //Se crea un objeto Dataset que es donde se devolverán los resultados
                DataSet ds = new DataSet();
                //Rellenamos con el Adaptador el DataSet diciendole de que tabla provienen los datos
                adp.Fill(ds, "RegsitrosDeEmpleados");
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


        public DataSet ObtenerPersonas()
        {
            try
            {
                // Establece la conexión a la base de datos
                command.Connection = getConnection();

                // Consulta SQL para obtener los empleados activos
                string query = "SELECT * FROM RegsitrosDeEmpleados";
                SqlCommand cmd = new SqlCommand(query, command.Connection);

                // Ejecuta la consulta sin obtener resultados
                cmd.ExecuteNonQuery();

                // Utiliza un SqlDataAdapter para llenar el DataSet con los datos de la consulta
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds, "RegsitrosDeEmpleados");

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

        public DataSet ObtenerPersonasInactivas()
        {
            try
            {
                //Accedemos a la conexión que ya se tiene
                command.Connection = getConnection();
                //Instrucción que se hará hacia la base de datos
                string query = "SELECT * FROM RegsitrosDeEmpleados WHERE EstadoEmpleado = @false";
                //Comando sql en el cual se pasa la instrucción y la conexión
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                //Asignando valor al parametro
                cmd.Parameters.AddWithValue("valor", false);
                //Se ejecuta el comando y con ExecuteNonQuery se verifica su retorno
                //ExecuteNonQuery devuelve un valor entero.
                cmd.ExecuteNonQuery();
                //Se utiliza un adaptador sql para rellenar el dataset
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                //Se crea un objeto Dataset que es donde se devolverán los resultados
                DataSet ds = new DataSet();
                //Rellenamos con el Adaptador el DataSet diciendole de que tabla provienen los datos
                adp.Fill(ds, "RegsitrosDeEmpleados");
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






        public int RegistarEmpleados()
        {
            try
            {
                // Establece la conexión a la base de datos
                command.Connection = getConnection();

                // Consulta SQL para insertar más detalles del empleado
                string query = "INSERT INTO Empleado VALUES (@param1, @param2, @param3, @param4, @param5, @param6, @param7, @param8, @param9)";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                cmd.Parameters.AddWithValue("param1", Role1);
                cmd.Parameters.AddWithValue("param2", Nombre1);
                cmd.Parameters.AddWithValue("param3", Apellido1);
                cmd.Parameters.AddWithValue("param4", FechaNacimiento1);
                cmd.Parameters.AddWithValue("param5", Usuario1);
                cmd.Parameters.AddWithValue("param6", Contraseña1);
                cmd.Parameters.AddWithValue("param7", CorreoElectronico1);
                cmd.Parameters.AddWithValue("param8", 0);
                cmd.Parameters.AddWithValue("param9", Estado1);
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
            string query = "DELETE FROM Empleado WHERE Usuario = @Usuario";
            SqlCommand cmddel = new SqlCommand(query, command.Connection);
            cmddel.Parameters.AddWithValue("Usuario", Usuario1);

            // Ejecuta la consulta de eliminación
            cmddel.ExecuteNonQuery();
        }

        public int ActualizarEmpleados()
        {
            try
            {
                // Establece la conexión a la base de datos
                command.Connection = getConnection();

                // Consulta SQL para actualizar los detalles del empleado
                string query = "UPDATE Empleado SET " +
                                "Nombre = @param2, " +
                                "Apellido = @param3, " +
                                "FechaNacimient = @param4, " +
                                "CorreoEmpleado = @param7";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                cmd.Parameters.AddWithValue("param2", Nombre1);
                cmd.Parameters.AddWithValue("param3", Apellido1);
                cmd.Parameters.AddWithValue("param4", FechaNacimiento1);
                cmd.Parameters.AddWithValue("param7", CorreoElectronico1);

                // Ejecuta la consulta de actualización y obtiene el número de filas afectadas
                int respuesta = cmd.ExecuteNonQuery();

                // Si la actualización de detalles fue exitosa, actualiza el rol del empleado
                if (respuesta == 1)
                {
                    // Consulta SQL para actualizar el rol del empleado
                    string query2 = "UPDATE Empleado SET " +
                                    "IdRole = @param1 " +
                                    "WHERE Usuario = @param5";
                    SqlCommand cmd2 = new SqlCommand(query2, getConnection());
                    cmd2.Parameters.AddWithValue("param1", Role1);
                    cmd2.Parameters.AddWithValue("param5", Usuario1);

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
                string query = "DELETE Empleado WHERE IdEmpleados = @param0";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                cmd.Parameters.AddWithValue("param0", IdEmpleado1);

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
