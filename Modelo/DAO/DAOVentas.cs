using Proyecto.Modelo.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto.Modelo.DAO
{
    internal class DAOVentas : DTOVentas
    {

        SqlCommand command = new SqlCommand();

        public DataSet LLenarcomboProducto()
        {
            try
            {

                command.Connection = getConnection();
                string query = "SELECT * FROM Producto";
                SqlCommand cmdSelect = new SqlCommand(query, command.Connection);
                cmdSelect.ExecuteNonQuery();
                SqlDataAdapter adp = new SqlDataAdapter(cmdSelect);
                DataSet ds = new DataSet();
                adp.Fill(ds, "Producto");
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
                command.Connection.Close();
            }
        }

        public DataSet LLenarcombocita()
        {
            try
            {

                command.Connection = getConnection();
                string query = "SELECT * FROM Citas";
                SqlCommand cmdSelect = new SqlCommand(query, command.Connection);
                cmdSelect.ExecuteNonQuery();
                SqlDataAdapter adp = new SqlDataAdapter(cmdSelect);
                DataSet ds = new DataSet();
                adp.Fill(ds, "Citas");
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
                command.Connection.Close();
            }
        }

        // Método para obtener todas las citas desde la base de datos
        public DataSet ObtenerMascotasActivas()
        {
            try
            {
                //Accedemos a la conexión que ya se tiene
                command.Connection = getConnection();
                //Instrucción que se hará hacia la base de datos
                string query = "SELECT * FROM ViewVentas WHERE EstadoVenta = @param1";
                //Comando sql en el cual se pasa la instrucción y la conexión
                SqlCommand cmd = new SqlCommand(query, command.Connection);
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
                adp.Fill(ds, "ViewVentas");
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
                command.Connection = getConnection();
                //Instrucción que se hará hacia la base de datos
                string query = "SELECT * FROM ViewVentas WHERE EstadoVenta = @param1";
                //Comando sql en el cual se pasa la instrucción y la conexión
                SqlCommand cmd = new SqlCommand(query, command.Connection);
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
                adp.Fill(ds, "ViewVentas");
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


        public int RegistarVentas()
        {
            try
            {
                // Establece la conexión a la base de datos
                command.Connection = getConnection();

                // Consulta SQL para insertar más detalles del empleado
                string query = "INSERT INTO Ventas VALUES (@param1, @param2, @param3)";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                cmd.Parameters.AddWithValue("param1", IdCitas1);
                cmd.Parameters.AddWithValue("param2", IdProductos1);
                cmd.Parameters.AddWithValue("param3", EstadoVenta1);
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
            string query = "DELETE FROM Ventas WHERE IdVentas = @IdVentas";
            SqlCommand cmddel = new SqlCommand(query, command.Connection);
            cmddel.Parameters.AddWithValue("IdVentas", IdVentas1);

            // Ejecuta la consulta de eliminación
            cmddel.ExecuteNonQuery();
        }

    }
}
