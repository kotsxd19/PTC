using Proyecto.Modelo.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Proyecto.Modelo.DAO
{
    internal class DAOCitas : DTOCitas
    {
        public int IdCitas { get; set; }
        public int IdEmpleados { get; set; }
        public int IdMascota { get; set; }
        public DateTime Fecha { get; set; }
        public TimeSpan Hora { get; set; }
        public string Descripcion { get; set; }

        public DataSet ObtenerCitas()
        {
            using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-AS08M5R\\SQLEXPRESS01;Initial Catalog=dbVetManager;Integrated Security=True;"))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Citas", conn);
                DataSet ds = new DataSet();
                da.Fill(ds, "Citas");
                return ds;
            }
        }

        public int EliminarCita()
        {
            using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-AS08M5R\\SQLEXPRESS01;Initial Catalog=dbVetManager;Integrated Security=True;"))
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Citas WHERE IdCitas = @IdCitas", conn);
                cmd.Parameters.AddWithValue("@IdCitas", IdCitas);
                conn.Open();
                return cmd.ExecuteNonQuery();
            }
        }

        public int IngresarCita()
        {
            using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-AS08M5R\\SQLEXPRESS01;Initial Catalog=dbVetManager;Integrated Security=True;"))
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Citas (IdEmpleados, IdMascota, Fecha, Hora, Descripcion) VALUES (@IdEmpleados, @IdMascota, @Fecha, @Hora, @Descripcion)", conn);
                cmd.Parameters.AddWithValue("@IdEmpleados", IdEmpleados);
                cmd.Parameters.AddWithValue("@IdMascota", IdMascota);
                cmd.Parameters.AddWithValue("@Fecha", Fecha);
                cmd.Parameters.AddWithValue("@Hora", Hora);
                cmd.Parameters.AddWithValue("@Descripcion", Descripcion);
                conn.Open();
                return cmd.ExecuteNonQuery();
            }
        }

        internal int EditarCita()
        {
            using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-AS08M5R\\SQLEXPRESS01;Initial Catalog=dbVetManager;Integrated Security=True;"))
            {
                SqlCommand cmd = new SqlCommand("UPDATE Citas SET IdEmpleados = @IdEmpleados, IdMascota = @IdMascota, Fecha = @Fecha, Hora = @Hora, Descripcion = @Descripcion WHERE IdCitas = @IdCitas", conn);
                cmd.Parameters.AddWithValue("@IdCitas", IdCitas);
                cmd.Parameters.AddWithValue("@IdEmpleados", IdEmpleados);
                cmd.Parameters.AddWithValue("@IdMascota", IdMascota);
                cmd.Parameters.AddWithValue("@Fecha", Fecha);
                cmd.Parameters.AddWithValue("@Hora", Hora);
                cmd.Parameters.AddWithValue("@Descripcion", Descripcion);
                conn.Open();
                return cmd.ExecuteNonQuery();
            }
        }
    }
}

