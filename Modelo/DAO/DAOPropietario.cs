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
    internal class DAOPropietario : DTOPropietario
    {
        readonly SqlCommand command = new SqlCommand();

        public DataSet LLenarDGV()
        {
            try
            {
                command.Connection = getConnection();
                string query = "SELECT * FROM Propietario";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds, "Propietario");
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos: {ex.Message}");
                return null;
            }
        }

        public int RegistrarPropietario()
        {
            try
            {
                using (SqlConnection connection = getConnection())
                {
                    string query = "INSERT INTO Propietario (Nombre, Apellido, Telefono) VALUES (@nombre, @apellido, @telefono)";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@nombre", Nombre);
                        cmd.Parameters.AddWithValue("@apellido", Apellido);
                        cmd.Parameters.AddWithValue("@telefono", Telefono);

                        int respuesta = cmd.ExecuteNonQuery();
                        return respuesta > 0 ? 1 : 0;  // 1 si la operación fue exitosa, 0 si no
                    }
                }
            }
            catch (SqlException sqlex)
            {
                MessageBox.Show(sqlex.Message);
                return -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return -1;
            }
        }

        public int ActualizarPropietario()
        {
            try
            {
                using (SqlConnection connection = getConnection())
                {
                    string query = "UPDATE Propietario SET Nombre = @Nombre, Apellido = @Apellido, Telefono = @Telefono WHERE idCliente = @idCliente";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", Nombre);
                        cmd.Parameters.AddWithValue("@Apellido", Apellido);
                        cmd.Parameters.AddWithValue("@Telefono", Telefono);
                        cmd.Parameters.AddWithValue("@idCliente", Dui);

                        int respuesta = cmd.ExecuteNonQuery();
                        return respuesta > 0 ? 1 : 0;  // 1 si la operación fue exitosa, 0 si no
                    }
                }
            }
            catch (SqlException sqlex)
            {
                MessageBox.Show(sqlex.Message);
                return -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return -1;
            }
        }

        public int EliminarPropietario()
        {
            try
            {
                using (SqlConnection connection = getConnection())
                {
                    string query = "DELETE FROM Propietario WHERE idCliente = @idCliente";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@idCliente", Dui);

                        int respuesta = cmd.ExecuteNonQuery();
                        return respuesta > 0 ? 1 : 0;  // 1 si la operación fue exitosa, 0 si no
                    }
                }
            }
            catch (SqlException sqlex)
            {
                MessageBox.Show(sqlex.Message);
                return -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return -1;
            }
        }

        internal DataSet ObtenerDueño()
        {
            throw new NotImplementedException();
        }
    }

}
