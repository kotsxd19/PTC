using Proyecto.Controlador.Validar;
using Proyecto.Modelo.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto.Modelo.DAO
{
    internal class DAOLogin : DTOLogin
    {
        SqlCommand Command = new SqlCommand();

        public bool Login()
        {
            try
            {
                Command.Connection = getConnection();
                string query = "SELECT Usuario, Contraseña, Nombre FROM Empleado WHERE Usuario = @Usuario AND Contraseña = @Contraseña";
                SqlCommand cmd = new SqlCommand(query, Command.Connection);
                cmd.Parameters.AddWithValue("@Usuario", Usuario1);
                cmd.Parameters.AddWithValue("@Contraseña", Contraseña1);

                //MessageBox.Show(Usuario1 +  " " + Contraseña1);
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    Acceso.Usuario = rd.GetString(rd.GetOrdinal("Usuario"));
                    Acceso.Contraseña = rd.GetString(rd.GetOrdinal("Contraseña"));
                    Acceso.Nombre = rd.GetString(rd.GetOrdinal("Nombre"));
                }
                //MessageBox.Show(1+ rd.HasRows.ToString());
                return rd.HasRows;
            }
            catch (SqlException sqlex)
            {
                MessageBox.Show(sqlex.Message);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                Command.Connection.Close();
            }
        }

        private SqlConnection getConnection()
        {
            throw new NotImplementedException();
        }
    }
}
