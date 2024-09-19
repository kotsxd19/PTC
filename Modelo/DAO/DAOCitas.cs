using System;
using System.Data;
using System.Data.SqlClient;

namespace Proyecto.Modelo.DAO
{
    internal class DAOCitas
    {
        // Propiedades que representan los campos de una cita
        public int IdCita { get; set; }      
        public int IdEmpleado { get; set; }    
        public int IdMascota { get; set; }     
        public DateTime Fecha { get; set; }    
        public TimeSpan Hora { get; set; }     
        public string Descripcion { get; set; } 

        // Método para obtener todas las citas desde la base de datos
        public DataSet ObtenerCitas()
        {
            // Establecer la conexión a la base de datos
            var conn = new SqlConnection("Data Source= SQL8020.site4now.net;Initial Catalog=dbVetManager;Integrated Security=True;");

            // Crear un adaptador para ejecutar la consulta y llenar el DataSet
            var da = new SqlDataAdapter("SELECT * FROM Citas", conn);
            var ds = new DataSet();
            da.Fill(ds, "Citas"); // Llenar el DataSet con los resultados de la consulta
            return ds; // Devolver el DataSet con las citas
        }

        // Método para eliminar una cita por su ID
        public int EliminarCita()
        {
            // Establecer la conexión a la base de datos
            var conn = new SqlConnection("Data Source= SQL8020.site4now.net;Initial Catalog=dbVetManager;Integrated Security=True;");

            // Crear el comando SQL para eliminar la cita
            var cmd = new SqlCommand("DELETE FROM Citas WHERE IdCitas = @IdCitas", conn);
            cmd.Parameters.AddWithValue("@IdCitas", IdCita); // Añadir el parámetro del ID de la cita

            conn.Open(); // Abrir la conexión
            return cmd.ExecuteNonQuery(); // Ejecutar el comando y devolver el número de filas afectadas
        }

        // Método para ingresar una nueva cita
        public int IngresarCita()
        {
            // Establecer la conexión a la base de datos
            var conn = new SqlConnection("Data Source= SQL8020.site4now.net;Initial Catalog=dbVetManager;Integrated Security=True;");

            // Crear el comando SQL para insertar la nueva cita
            var cmd = new SqlCommand("INSERT INTO Citas (IdEmpleados, IdMascota, Fecha, Hora, Descripcion) VALUES (@IdEmpleados, @IdMascota, @Fecha, @Hora, @Descripcion)", conn);

            // Añadir los parámetros necesarios para la inserción
            cmd.Parameters.AddWithValue("@IdEmpleados", IdEmpleado);
            cmd.Parameters.AddWithValue("@IdMascota", IdMascota);
            cmd.Parameters.AddWithValue("@Fecha", Fecha);
            cmd.Parameters.AddWithValue("@Hora", Hora.ToString(@"hh\:mm\:ss")); // Formatear la hora correctamente
            cmd.Parameters.AddWithValue("@Descripcion", Descripcion);

            conn.Open(); // Abrir la conexión
            return cmd.ExecuteNonQuery(); // Ejecutar el comando y devolver el número de filas afectadas
        }

        // Método para editar una cita existente
        public int EditarCita()
        {
            // Establecer la conexión a la base de datos
            var conn = new SqlConnection("Data Source= SQL8020.site4now.net;Initial Catalog=dbVetManager;Integrated Security=True;");

            // Crear el comando SQL para actualizar la cita
            var cmd = new SqlCommand("UPDATE Citas SET IdEmpleados = @IdEmpleados, IdMascota = @IdMascota, Fecha = @Fecha, Hora = @Hora, Descripcion = @Descripcion WHERE IdCitas = @IdCitas", conn);

            // Añadir los parámetros necesarios para la actualización
            cmd.Parameters.AddWithValue("@IdCitas", IdCita);
            cmd.Parameters.AddWithValue("@IdEmpleados", IdEmpleado);
            cmd.Parameters.AddWithValue("@IdMascota", IdMascota);
            cmd.Parameters.AddWithValue("@Fecha", Fecha);
            cmd.Parameters.AddWithValue("@Hora", Hora.ToString(@"hh\:mm\:ss")); // Formatear la hora correctamente
            cmd.Parameters.AddWithValue("@Descripcion", Descripcion);

            conn.Open(); // Abrir la conexión
            return cmd.ExecuteNonQuery(); // Ejecutar el comando y devolver el número de filas afectadas
        }
    }

}

