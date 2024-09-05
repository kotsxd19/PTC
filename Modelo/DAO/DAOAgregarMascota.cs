using Proyecto.Modelo.DTO;

using System;

using System.Collections.Generic;

using System.Data.SqlClient;

using System.Linq;

using System.Net;

using System.Text;

using System.Threading.Tasks;

using System.Windows.Input;

using System.Data.SqlClient;

namespace Proyecto.Modelo.DAO
{
    public class MascotaDAO
    {
        private readonly SqlConnection _connection; 

        public MascotaDAO(string connectionString)
        {
            _connection = new SqlConnection(connectionString);
        }

        public int InsertarMascota(ControladorMascota mascota) 
        {
            try
            {
                _connection.Open();

                string query = "INSERT INTO Mascotas (Nombre, Raza, Dueño, Peso, Genero, FechaNacimiento) VALUES (@Nombre, @Raza, @Dueño, @Peso, @Genero, @FechaNacimiento)";

                using (SqlCommand command = new SqlCommand(query, _connection))
                {
                    command.Parameters.AddWithValue("@Nombre", mascota.Nombre);
                    command.Parameters.AddWithValue("@Raza", mascota.Raza);
                    command.Parameters.AddWithValue("@Dueño", mascota.Dueño);
                    command.Parameters.AddWithValue("@Peso", mascota.Peso);
                    command.Parameters.AddWithValue("@Genero", mascota.Genero);
                    command.Parameters.AddWithValue("@FechaNacimiento", mascota.FechaNacimiento);

                    return command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar la mascota: " + ex.Message);
                return -1; 
            }
            finally
            {
                _connection.Close(); 
            }
        }
    }
}
