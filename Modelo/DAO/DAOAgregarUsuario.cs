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
                command.Connection = getConnection();
                string query = "SELECT * FROM Roles";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                cmd.ExecuteNonQuery();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "dbRoles");
                return ds;
            }
            catch (Exception)
            {

                return null;
            }
            finally
            {
                getConnection().Close();
            }
        }

        public int RegistarEmpleados()
        {
            try
            {
                command.Connection = getConnection();
                string query2 = "INSERT INTO Empleado VALUES (@Usuario, @Contraseña, @Nombre, @Apellido, @CorreoEmpleado, @FechaNacimient )";
                SqlCommand cmd2 = new SqlCommand(query2, command.Connection);

                cmd2.Parameters.AddWithValue("Usuario", Usuario1);
                cmd2.Parameters.AddWithValue("Contraseña", Contraseña1);
                cmd2.Parameters.AddWithValue("Nombre", Nombre1);
                cmd2.Parameters.AddWithValue("Apellido", Apellido1);
                cmd2.Parameters.AddWithValue("CorreoEmpleado", CorreoElectronico1);
                cmd2.Parameters.AddWithValue("FechaNacimient", FechaNacimiento1);
                int repuesta = cmd2.ExecuteNonQuery();

                if (repuesta == 1)
                {
                    string query = "INSERT INTO Empleado(Nombre, Apellido, FechaNacimient, CorreoEmpleado) VALUES (@param1, @param2, @param3, @param4)";
                    SqlCommand cmd = new SqlCommand(query, command.Connection);
                    cmd.Parameters.AddWithValue("param1", Nombre1);
                    cmd.Parameters.AddWithValue("param2", Apellido1);
                    cmd.Parameters.AddWithValue("param3", FechaNacimiento1);
                    cmd.Parameters.AddWithValue("param4", CorreoElectronico1);
                    cmd.Parameters.AddWithValue("param5", Usuario1);
                    cmd.Parameters.AddWithValue("param6", Contraseña1);

                    repuesta = cmd.ExecuteNonQuery();

                    return repuesta;
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception)
            {
                RollBack();
                return -1;
            }
            finally
            {
                RollBack();
                command.Connection.Close();
            }
        }

        public void RollBack()
        {
            //Eliminar el usuario ingresado
            string query = "DELETE FROM Empleado WHERE Usuario = @Usuario";
            SqlCommand cmddel = new SqlCommand(query, command.Connection);
            cmddel.Parameters.AddWithValue("Usuario", Usuario1);
            int retorno = cmddel.ExecuteNonQuery();
        }

        public DataSet ObtenerPersonas()
        {
            try
            {
                //Accedemos a la conexión que ya se tiene
                command.Connection = getConnection();
                //Instrucción que se hará hacia la base de datos
                string query = "SELECT * FROM viewPerson WHERE userStatus = @valor";
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
                adp.Fill(ds, "viewPerson");
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

        public int ActualizarEmpleados()
        {
            try
            {
                //Se crea una conexión para garantizar que efectivamente haya conexión a la base.
                command.Connection = getConnection();
                //**
                //Se crea el query que indica la acción que el sistema desea realizar con la base de datos
                //el query posee parametros para evitar algún tipo de ataque como SQL Injection
                string query = "UPDATE Empleado SET " +
                                "Nombre = @param1, " +
                                "Apellido = @param2, " +
                                "FechaNacimient = @param3, " +
                                "CorreoEmpleado = @param4,";
                //Se crea un comando de tipo sql al cual se le pasa el query y la conexión, esto para que el sistema sepa que hacer y donde hacerlo.
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                //Se le da un valor a los parametros contenidos en el query, es importante mencionar que lo que esta entre comillas es el nombre del parametro y lo que esta después de la coma es el valor que se le asignará al parametro, estos valores vienen del DTO respectivo.
                cmd.Parameters.AddWithValue("param1", Usuario1);
                cmd.Parameters.AddWithValue("param2", Apellido1);
                cmd.Parameters.AddWithValue("param3", FechaNacimiento1);
                cmd.Parameters.AddWithValue("param4", CorreoElectronico1);
                //Se ejecuta el comando ya con todos los valores de sus parametros.
                //ExecuteNonQuery indicará cuantos filas fueron afectadas, es decir, cuantas filas de datos se ingresaron, por lo general devolvera 1 porque se hace una actualización a la vez.
                int respuesta = cmd.ExecuteNonQuery();
                //Se evalúa el valor de la variable respuesta que contiene el numero de filas afectadas
                if (respuesta == 1)
                {
                    //Si el valor de respuesta es 1 se procede a realizar la actualización del usuario
                    //**
                    //Se crea el query que indica la acción que el sistema desea realizar con la base de datos
                    //el query posee parametros para evitar algún tipo de ataque como SQL Injection
                    string query2 = "UPDATE Empleado SET " +
                                    "Role = @param9 " +
                                    "WHERE Usuario = @param10";
                    //Se crea un comando de tipo sql al cual se le pasa el query y la conexión, esto para que el sistema sepa que hacer y donde hacerlo.
                    SqlCommand cmd2 = new SqlCommand(query2, getConnection());
                    //Se le da un valor a los parametros contenidos en el query, es importante mencionar que lo que esta entre comillas es el nombre del parametro y lo que esta después de la coma es el valor que se le asignará al parametro, estos valores vienen del DTO respectivo.
                    cmd2.Parameters.AddWithValue("param9", Role1);
                    cmd2.Parameters.AddWithValue("param10", Usuario1);
                    //Se ejecuta el comando ya con todos los valores de sus parametros.
                    //ExecuteNonQuery indicará cuantos filas fueron afectadas, es decir, cuantas filas de datos se ingresaron, por lo general devolvera 1 porque se hace una inserción a la vez.
                    respuesta = cmd2.ExecuteNonQuery();
                    respuesta = 2;
                }
                return respuesta;
            }
            catch (Exception)
            {
                //Se retorna -1 en caso que en el segmento del try haya ocurrido algún error.
                return -1;
            }
            finally
            {
                //Independientemente se haga o no el proceso cerramos la conexión
                getConnection().Close();
            }
        }

        public int EliminarEmplado()
        {
            try
            {
                //Se crea una conexión para garantizar que efectivamente haya conexión a la base.
                command.Connection = getConnection();
                //**
                //Se crea el query que indica la acción que el sistema desea realizar con la base de datos
                //el query posee parametros para evitar algún tipo de ataque como SQL Injection
                string query = "DELETE tbPerson WHERE IdEmpleado = @param1";
                //Se crea un comando de tipo sql al cual se le pasa el query y la conexión, esto para que el sistema sepa que hacer y donde hacerlo.
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                //Se le da un valor a los parametros contenidos en el query, es importante mencionar que lo que esta entre comillas es el nombre del parametro y lo que esta después de la coma es el valor que se le asignará al parametro, estos valores vienen del DTO respectivo.
                cmd.Parameters.AddWithValue("param1", IdEmpleado1);
                //Se ejecuta el comando ya con todos los valores de sus parametros.
                //ExecuteNonQuery indicará cuantos filas fueron afectadas, es decir, cuantas filas de datos se ingresaron, por lo general devolvera 1 porque se hace una eliminación a la vez.
                int respuesta = cmd.ExecuteNonQuery();
                //Si la ejecución del comando no ha generado errores se procederá a retornar el valor de la variable respuesta que por lo general almacenará un 1 ya que solo se hace una acción a la vez.
                if (respuesta == 1)
                {
                    string queryupdate = "UPDATE Empleado SET WHERE Usuario = @Usuario";
                    SqlCommand cmdupdate = new SqlCommand(queryupdate, command.Connection);
                    cmdupdate.Parameters.AddWithValue("username", Usuario1);
                    respuesta += cmdupdate.ExecuteNonQuery();
                }
                return respuesta;
            }
            catch (Exception)
            {
                //Se retorna -1 en caso que en el segmento del try haya ocurrido algún error.
                return -1;
            }
            finally
            {
                //Independientemente se haga o no el proceso cerramos la conexión
                getConnection().Close();
            }
        }
    }
}
