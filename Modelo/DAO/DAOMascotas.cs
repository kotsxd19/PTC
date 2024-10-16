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
    internal class DAOMascotas : DTOMascotas
    {
        readonly SqlCommand command = new SqlCommand();
        public DataSet LLenarDGV()
        {
            try
            {
                command.Connection = getConnection();
                string query = "Select * from Mascota";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                cmd.ExecuteNonQuery();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds, "Mascota");
                return ds;
            }
            catch (Exception)
            {

                return null;
            }
        }

        public int RegistrarMascota()
        {
            try
            {
                command.Connection = getConnection();
                string query = "Insert into Mascota values (@nombre, @peso, @genero, @dueño, @raza)";
                SqlCommand cmd = new SqlCommand(@query, command.Connection);
                cmd.Parameters.AddWithValue("@nombre", Nombre);
                cmd.Parameters.AddWithValue("@peso", Peso);
                cmd.Parameters.AddWithValue("@genero", Genero);
                cmd.Parameters.AddWithValue("@dueño", Dueño);
                cmd.Parameters.AddWithValue("@raza", Dueño);
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

        public int ActualizarMascota()
        {
            try
            {
                command.Connection = getConnection();
                string query = "Update Mascota set Nombre = @Nombre, peso = @peso, genero = @genero Dueño = @Dueño raza = @raza where idMascota = @idMascota";
                SqlCommand cmd = new SqlCommand(@query, command.Connection);
                cmd.Parameters.AddWithValue("Nombre", Nombre);
                cmd.Parameters.AddWithValue("Peso", Peso);
                cmd.Parameters.AddWithValue("Genero", Genero);
                cmd.Parameters.AddWithValue("Dueño", Dueño);
                cmd.Parameters.AddWithValue("raza", Idraza);
                cmd.Parameters.AddWithValue("IdMascota", Idmascota);
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
        public int EliminarMascota()
        {
            try
            {
                command.Connection = getConnection();
                string query = "Delete Propietario where idMascota = @idMascota";
                SqlCommand cmd = new SqlCommand(@query, command.Connection);
                cmd.Parameters.AddWithValue("idMascota", Idmascota);
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

        internal DataSet ObtenerMascotas()
        {
            throw new NotImplementedException();
        }
    }
}
