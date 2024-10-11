using Proyecto.Modelo.DTO;
using System;
using System.Data;
using System.Data.SqlClient;
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

                Conexion.Connection = getConexion();
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

        // Método para obtener todas las citas desde la base de datos
        public DataSet ObtenerCitas()
        {
            Conexion.Connection = getConexion();

           // // Establecer la conexión a la base de datos
           // var conn = new SqlConnection("Data Source= SQL8020.site4now.net;Initial Catalog=dbVetManager;");
           //// Crear un adaptador para ejecutar la consulta y llenar el DataSet

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Citas", Conexion.Connection);
            DataSet ds = new DataSet();
            da.Fill(ds, "Citas"); // Llenar el DataSet con los resultados de la consulta
            return ds; // Devolver el DataSet con las citas
        }

        // Método para eliminar una cita por su ID
        public int EliminarCita()
        {
            // Establecer la conexión a la base de datos
            var conn = new SqlConnection("Data Source= SQL8020.site4now.net;Initial Catalog=dbVetManager;");

            // Crear el comando SQL para eliminar la cita
            var cmd = new SqlCommand("DELETE FROM Citas WHERE IdCitas = @IdCitas", Conexion.Connection);
            cmd.Parameters.AddWithValue("@IdCitas", IdCitas); // Añadir el parámetro del ID de la cita

            conn.Open(); // Abrir la conexión
            return cmd.ExecuteNonQuery(); // Ejecutar el comando y devolver el número de filas afectadas
        }

        // Método para ingresar una nueva cita
        public int IngresarCita()
        {
            Conexion.Connection = getConexion();
             var conn = new SqlConnection("Data Source= SQL8020.site4now.net;Initial Catalog=dbVetManager;");
            string query = "INSERT INTO Citas (IdEmpleados, IdMascota, Fecha, Hora, Descripcion) VALUES (@IdEmpleados, @IdMascota, @Fecha, @Hora, @Descripcion)";
            // Crear el comando SQL para insertar la nueva cita
            SqlCommand cmd = new SqlCommand(query, Conexion.Connection);
            
            // Añadir los parámetros necesarios para la inserción
            cmd.Parameters.AddWithValue("@IdEmpleados", IdEmpleados);
            cmd.Parameters.AddWithValue("@IdMascota", IdMascota1);
            cmd.Parameters.AddWithValue("@Fecha", Fecha);
            cmd.Parameters.AddWithValue("@Hora", Hora.ToString(@"hh\:mm\:ss")); // Formatear la hora correctamente
            cmd.Parameters.AddWithValue("@Descripcion", Descripcion);
            int respuesta = cmd.ExecuteNonQuery();
            // Abrir la conexión
            return respuesta; // Ejecutar el comando y devolver el número de filas afectadas
        }

        // Método para editar una cita existente
        public int EditarCita()
        {
            // Establecer la conexión a la base de datos
            var conn = new SqlConnection("Data Source= SQL8020.site4now.net;Initial Catalog=dbVetManager;");

            // Crear el comando SQL para actualizar la cita
            var cmd = new SqlCommand("UPDATE Citas SET IdEmpleados = @IdEmpleados, IdMascota = @IdMascota, Fecha = @Fecha, Hora = @Hora, Descripcion = @Descripcion WHERE IdCitas = @IdCitas", conn);

            // Añadir los parámetros necesarios para la actualización
            cmd.Parameters.AddWithValue("@IdCitas", IdCitas);
            cmd.Parameters.AddWithValue("@IdEmpleados", IdEmpleados);
            cmd.Parameters.AddWithValue("@IdMascota", IdMascota1);
            cmd.Parameters.AddWithValue("@Fecha", Fecha);
            cmd.Parameters.AddWithValue("@Hora", Hora.ToString(@"hh\:mm\:ss")); // Formatear la hora correctamente
            cmd.Parameters.AddWithValue("@Descripcion", Descripcion);

            conn.Open(); // Abrir la conexión
            return cmd.ExecuteNonQuery(); // Ejecutar el comando y devolver el número de filas afectadas
        }
    }

}