using System;
using System.Data;
using System.Data.SqlClient;

namespace Proyecto.Modelo.DAO
{
    internal class DAOCitas
    {
        public int IdCita { get; set; }
        public int IdEmpleado { get; set; }
        public int IdMascota { get; set; }
        public DateTime Fecha { get; set; }
        public TimeSpan Hora { get; set; }
        public string Descripcion { get; set; }

        public DataSet ObtenerCitas()
        {
            var conn = new SqlConnection("Data Source=DESKTOP-AS08M5R\\SQLEXPRESS01;Initial Catalog=dbVetManager;Integrated Security=True;");
            var da = new SqlDataAdapter("SELECT * FROM Citas", conn);
            var ds = new DataSet();
            da.Fill(ds, "Citas");
            return ds;
        }

        public int EliminarCita()
        {
            var conn = new SqlConnection("Data Source=DESKTOP-AS08M5R\\SQLEXPRESS01;Initial Catalog=dbVetManager;Integrated Security=True;");
            var cmd = new SqlCommand("DELETE FROM Citas WHERE IdCitas = @IdCitas", conn);
            cmd.Parameters.AddWithValue("@IdCitas", IdCita);
            conn.Open();
            return cmd.ExecuteNonQuery();
        }

        public int IngresarCita()
        {
            var conn = new SqlConnection("Data Source=DESKTOP-AS08M5R\\SQLEXPRESS01;Initial Catalog=dbVetManager;Integrated Security=True;");
            var cmd = new SqlCommand("INSERT INTO Citas (IdEmpleados, IdMascota, Fecha, Hora, Descripcion) VALUES (@IdEmpleados, @IdMascota, @Fecha, @Hora, @Descripcion)", conn);
            cmd.Parameters.AddWithValue("@IdEmpleados", IdEmpleado);
            cmd.Parameters.AddWithValue("@IdMascota", IdMascota);
            cmd.Parameters.AddWithValue("@Fecha", Fecha);
            // Aquí aseguramos que la hora se inserte en el formato correcto (HH:mm:ss)
            cmd.Parameters.AddWithValue("@Hora", Hora.ToString(@"hh\:mm\:ss"));
            cmd.Parameters.AddWithValue("@Descripcion", Descripcion);
            conn.Open();
            return cmd.ExecuteNonQuery();
        }

        public int EditarCita()
        {
            var conn = new SqlConnection("Data Source=DESKTOP-AS08M5R\\SQLEXPRESS01;Initial Catalog=dbVetManager;Integrated Security=True;");
            var cmd = new SqlCommand("UPDATE Citas SET IdEmpleados = @IdEmpleados, IdMascota = @IdMascota, Fecha = @Fecha, Hora = @Hora, Descripcion = @Descripcion WHERE IdCitas = @IdCitas", conn);
            cmd.Parameters.AddWithValue("@IdCitas", IdCita);
            cmd.Parameters.AddWithValue("@IdEmpleados", IdEmpleado);
            cmd.Parameters.AddWithValue("@IdMascota", IdMascota);
            cmd.Parameters.AddWithValue("@Fecha", Fecha);
            cmd.Parameters.AddWithValue("@Hora", Hora.ToString(@"hh\:mm\:ss"));
            cmd.Parameters.AddWithValue("@Descripcion", Descripcion);
            conn.Open();
            return cmd.ExecuteNonQuery();
        }
    }
}

