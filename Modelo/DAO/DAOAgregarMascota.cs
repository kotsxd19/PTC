using Proyecto.Modelo.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Modelo.DAO
{
    internal class DAOAgregarMascota:DTOAgregarMascota
    {
        SqlCommand Command = new SqlCommand();

        public bool AgregarMascota()
        {
            try
            {
                Command.Connection = getConnection();
                int query = "SELECT IdMascota, IdCliente, IdRaza FROM Mascota WHERE IdMascota = @IdMascota AND IdCliente = @IdCliente AND IdRaza = @IdRaza";
                SqlCommand cmd = new SqlCommand(query, Command.Connection);
                cmd.Parameters.AddWithValue("@IdMascota", IdMascota1);
                cmd.Parameters.AddWithValue("@IdCliente", IdCliente1);
                cmd.Parameters.AddWithValue("@IdRaza", IdRaza1);

            }
        }
    }
}
