using Proyecto.Modelo.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto.Modelo.DAO
{
    internal class DAOCitas : DTOCitas
    {

        // Propiedades que representan los campos de una cita
        readonly SqlCommand Conexion = new SqlCommand();

        public DataSet LLenarcomboEmpleados()
        {
            try
            {

                Conexion.Connection = getConnection();
                string query = "SELECT * FROM Empleado";
                SqlCommand cmdSelect = new SqlCommand(query, Conexion.Connection);
                cmdSelect.ExecuteNonQuery();
                SqlDataAdapter adp = new SqlDataAdapter(cmdSelect);
                DataSet ds = new DataSet();
                adp.Fill(ds, "Empleado");
                return ds;
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"{ex.Message}");
                MessageBox.Show($"Error al obtener los empleados, verifique su conexión a internet o que el acceso al servidor o base de datos esten activos", "Error de ejecución", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                Conexion.Connection.Close();
            }
        }

        public DataSet LLenarcomboBOXmascota()
        {
            try
            {

                Conexion.Connection = getConnection();
                string query = "SELECT * FROM Mascota";
                SqlCommand cmdSelect = new SqlCommand(query, Conexion.Connection);
                cmdSelect.ExecuteNonQuery();
                SqlDataAdapter adp = new SqlDataAdapter(cmdSelect);
                DataSet ds = new DataSet();
                adp.Fill(ds, "Mascota");
                return ds;
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"{ex.Message}");
                MessageBox.Show($"Error al obtener los empleados, verifique su conexión a internet o que el acceso al servidor o base de datos esten activos", "Error de ejecución", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                Conexion.Connection.Close();
            }
        }

        // Método para obtener todas las citas desde la base de datos
        public DataSet ObtenerMascotasActivas()
        {
            try
            {
                //Accedemos a la conexión que ya se tiene
                Conexion.Connection = getConnection();
                //Instrucción que se hará hacia la base de datos
                string query = "SELECT * FROM ViewCita WHERE EstadoCita = @param1";
                //Comando sql en el cual se pasa la instrucción y la conexión
                SqlCommand cmd = new SqlCommand(query, Conexion.Connection);
                //Asignando valor al parametro
                cmd.Parameters.AddWithValue("param1", 1);
                //Se ejecuta el comando y con ExecuteNonQuery se verifica su retorno
                //ExecuteNonQuery devuelve un valor entero.
                cmd.ExecuteNonQuery();
                //Se utiliza un adaptador sql para rellenar el dataset
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                //Se crea un objeto Dataset que es donde se devolverán los resultados
                DataSet ds = new DataSet();
                //Rellenamos con el Adaptador el DataSet diciendole de que tabla provienen los datos
                adp.Fill(ds, "ViewCita");
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




        public DataSet ObtenerMascotasInactivas()
        {
            try
            {
                //Accedemos a la conexión que ya se tiene
                Conexion.Connection = getConnection();
                //Instrucción que se hará hacia la base de datos
                string query = "SELECT * FROM ViewCita WHERE EstadoCita = @param1";
                //Comando sql en el cual se pasa la instrucción y la conexión
                SqlCommand cmd = new SqlCommand(query, Conexion.Connection);
                //Asignando valor al parametro
                cmd.Parameters.AddWithValue("param1", 0);
                //Se ejecuta el comando y con ExecuteNonQuery se verifica su retorno
                //ExecuteNonQuery devuelve un valor entero.
                cmd.ExecuteNonQuery();
                //Se utiliza un adaptador sql para rellenar el dataset
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                //Se crea un objeto Dataset que es donde se devolverán los resultados
                DataSet ds = new DataSet();
                //Rellenamos con el Adaptador el DataSet diciendole de que tabla provienen los datos
                adp.Fill(ds, "ViewCita");
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

        // Método para eliminar una cita por su ID


        // Método para ingresar una nueva cita
        public int Registarcitas()
        {
            try
            {
                // Establece la conexión a la base de datos
                Conexion.Connection = getConnection();

                // Consulta SQL para insertar más detalles del empleado
                string query = "INSERT INTO Citas VALUES (@param1, @param2, @param3, @param4, @param5, @param6)";
                SqlCommand cmd = new SqlCommand(query, Conexion.Connection);
                cmd.Parameters.AddWithValue("param1", IdEmpleados);
                cmd.Parameters.AddWithValue("param2", IdMascota1);
                cmd.Parameters.AddWithValue("param3", Fecha);
                cmd.Parameters.AddWithValue("param4", Hora);
                cmd.Parameters.AddWithValue("param5", Descripcion);
                cmd.Parameters.AddWithValue("param6", ESTADOCITA1);
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

                Conexion.Connection.Close();
            }
        }

        public void RollBack()
        {
            // Consulta SQL para eliminar el usuario en caso de un fallo
            string query = "DELETE FROM Citas WHERE IdCita = @IdCita";
            SqlCommand cmddel = new SqlCommand(query, Conexion.Connection);
            cmddel.Parameters.AddWithValue("IdCita", IdCitas);

            // Ejecuta la consulta de eliminación
            cmddel.ExecuteNonQuery();
        }

        public DataSet BuscarCitas(string valor)
        {
            try
            {
                //Accedemos a la conexión que ya se tiene
                Conexion.Connection = getConnection();
                //Instrucción que se hará hacia la base de datos
                string query = $"SELECT * FROM ViewCita WHERE Descripcion LIKE '%{valor}%'";
                //Comando sql en el cual se pasa la instrucción y la conexión
                SqlCommand cmd = new SqlCommand(query, Conexion.Connection);
                //Se ejecuta el comando y con ExecuteNonQuery se verifica su retorno
                //ExecuteNonQuery devuelve un valor entero.
                cmd.ExecuteNonQuery();
                //Se utiliza un adaptador sql para rellenar el dataset
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                //Se crea un objeto Dataset que es donde se devolverán los resultados
                DataSet ds = new DataSet();
                //Rellenamos con el Adaptador el DataSet diciendole de que tabla provienen los datos
                adp.Fill(ds, "ViewCita");
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
