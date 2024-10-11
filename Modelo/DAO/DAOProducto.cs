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
    internal class DAOProducto : DTOProducto
    {
        SqlCommand command = new SqlCommand();

        public DataSet LlenarComboBox()
        {
            try
            {
                // Establece la conexión a la base de datos
                command.Connection = getConnection();

                // Consulta SQL para obtener todos los roles
                string query = "SELECT * FROM Proveedor";
                SqlCommand cmd = new SqlCommand(query, command.Connection);

                // Ejecuta la consulta sin obtener resultados
                cmd.ExecuteNonQuery();

                // Utiliza un SqlDataAdapter para llenar el DataSet con los datos de la consulta
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "Proveedor");

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

        public DataSet ObetenerProductos()
        {

            try
            {
                //Accedemos a la conexión que ya se tiene
                command.Connection = getConnection();
                //Instrucción que se hará hacia la base de datos
                string query = "SELECT * FROM VistaProductos";
                //Comando sql en el cual se pasa la instrucción y la conexión
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                //Asignando valor al parametro
                //Se ejecuta el comando y con ExecuteNonQuery se verifica su retorno
                //ExecuteNonQuery devuelve un valor entero.
                cmd.ExecuteNonQuery();
                //Se utiliza un adaptador sql para rellenar el dataset
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                //Se crea un objeto Dataset que es donde se devolverán los resultados
                DataSet ds = new DataSet();
                //Rellenamos con el Adaptador el DataSet diciendole de que tabla provienen los datos
                adp.Fill(ds, "VistaProductos");
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

        public int RegistarProducto()
        {


            try
            {
                // Establece la conexión a la base de datos
                command.Connection = getConnection();
                string query = "INSERT INTO Producto VALUES (@param1, @param2, @param3, @param4)";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                cmd.Parameters.AddWithValue("param1", IdProveedor1);
                cmd.Parameters.AddWithValue("param2", Nombre1);
                cmd.Parameters.AddWithValue("param3", Precio1);
                cmd.Parameters.AddWithValue("param4", CodigoDeBarra1);
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
            string query = "DELETE FROM Producto WHERE Producto = @Producto";
            SqlCommand cmddel = new SqlCommand(query, command.Connection);
            cmddel.Parameters.AddWithValue("Nombre", Nombre1);

            // Ejecuta la consulta de eliminación
            cmddel.ExecuteNonQuery();
        }

        //public int ActualizarProveedor()
        //{
        //    try
        //    {
        //        // Establece la conexión a la base de datos
        //        command.Connection = getConnection();

        //        // Consulta SQL para actualizar los detalles del empleado
        //        string query = "UPDATE Producto SET " +
        //                        "Nombre = @param2, ";
        //        SqlCommand cmd = new SqlCommand(query, command.Connection);
        //        cmd.Parameters.AddWithValue("param1", );

        //        // Ejecuta la consulta de actualización y obtiene el número de filas afectadas
        //        int respuesta = cmd.ExecuteNonQuery();

        //        // Retorna el resultado de la actualización
        //        return respuesta;
        //    }
        //    catch (Exception)
        //    {
        //        // Retorna -1 en caso de error
        //        return -1;
        //    }
        //    finally
        //    {
        //        // Cierra la conexión a la base de datos
        //        getConnection().Close();
        //    }
        //}

        //public int EliminarProveedor()
        //{
        //    try
        //    {
        //        // Establece la conexión a la base de datos 
        //        command.Connection = getConnection();

        //        // Consulta SQL para eliminar al empleado
        //        string query = "DELETE Proveedor WHERE IdProveedor = @param0";
        //        SqlCommand cmd = new SqlCommand(query, command.Connection);
        //        cmd.Parameters.AddWithValue("param0", IdProveedor1);

        //        // Ejecuta la consulta de eliminación y obtiene el número de filas afectadas
        //        int respuesta = cmd.ExecuteNonQuery();

        //        // Retorna el resultado de la eliminación
        //        return respuesta;
        //    }
        //    catch (Exception)
        //    {
        //        // Retorna -1 en caso de error
        //        return -1;
        //    }
        //    finally
        //    {
        //        // Cierra la conexión a la base de datos
        //        getConnection().Close();
        //    }
        //}
    }
}
