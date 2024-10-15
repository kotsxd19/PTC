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
    internal class DAOPropietario : DTOPropietario
    {
        readonly SqlCommand command = new SqlCommand();
        public DataSet LLenarDGV()
        {
            try
            {
                command.Connection = getConnection();
                string query = "Select * from Propietario";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                cmd.ExecuteNonQuery();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds, "Propietario");
                return ds;
            }
            catch (Exception)
            {

                return null;
            }

        }
        public int RegistrarPropietario()
        {
            try
            {
                command.Connection = getConnection();
                string query = "Insert into Propietario values (@nombre, @apellido, @telefono)";
                SqlCommand cmd = new SqlCommand(@query, command.Connection);
                cmd.Parameters.AddWithValue("@nombre", Nombre);
                cmd.Parameters.AddWithValue("@apellido", Apellido);
                cmd.Parameters.AddWithValue("@telefono", Telefono);
                int respuesta = cmd.ExecuteNonQuery();
                respuesta = 1;
                return respuesta;
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
            finally
            {
                getConnection().Close();
            }
        }
        public int ActualizarPropietario()
        {
            try
            {
                command.Connection = getConnection();
                string query = "Update Propietario set Nombre = @Nombre, Apellido = @Apellido, Telefono = @Telefono where idCliente = @idCliente";
                SqlCommand cmd = new SqlCommand(@query, command.Connection);
                cmd.Parameters.AddWithValue("Nombre", Nombre);
                cmd.Parameters.AddWithValue("Apellido", Apellido);
                cmd.Parameters.AddWithValue("Telefono", Telefono);
                cmd.Parameters.AddWithValue("idCliente", Dui);
                int respuesta = cmd.ExecuteNonQuery();
                respuesta = 1;
                return respuesta;
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
            finally
            {
                getConnection().Close();
            }
        }
        public int EliminarPropietario()
        {
            try
            {
                command.Connection = getConnection();
                string query = "Delete Propietario where idCliente = @idCliente";
                SqlCommand cmd = new SqlCommand(@query, command.Connection);
                cmd.Parameters.AddWithValue("idCliente", Dui);
                int respuesta = cmd.ExecuteNonQuery();
                respuesta = 1;
                return respuesta;
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
            finally
            {
                getConnection().Close();
            }
        }
    }
}
