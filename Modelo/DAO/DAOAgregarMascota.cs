using Proyecto.Modelo.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
namespace Proyecto.Modelo.DAO
{
    public class MascotaDAO
    {
        private string connectionString = "tu_cadena_de_conexion"; // Reemplaza con tu cadena de conexión

        public void FrmAgregarUsuario(DTOAgregarMascotas mascota)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Mascotas (IdCliente, IdRaza, Nombre, Peso, Genero, Dueño) " +
                               "VALUES (@IdCliente, @IdRaza, @Nombre, @Peso, @Genero, @Dueño)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@IdCliente", mascota.IdCliente);
                    command.Parameters.AddWithValue("@IdRaza", mascota.IdRaza);
                    command.Parameters.AddWithValue("@Nombre", mascota.Nombre);
                    command.Parameters.AddWithValue("@Peso", mascota.Peso);
                    command.Parameters.AddWithValue("@Genero", mascota.Genero);
                    command.Parameters.AddWithValue("@Dueño", mascota.Dueño);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        // Otros métodos: ObtenerMascotaPorId, ActualizarMascota, EliminarMascota, etc.
    }
}