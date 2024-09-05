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
                using (SqlConnection connection = getConnection())
                {
                    string query = "SELECT Usuario, Contraseña, Nombre FROM Empleado WHERE Usuario = @Usuario AND Contraseña = @Contraseña";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Usuario", Usuario1);
                        cmd.Parameters.AddWithValue("@Contraseña", Contraseña1);

                        SqlDataReader rd = cmd.ExecuteReader();
                        if (rd.Read())
                        {
                            Acceso.Usuario = rd.GetString(rd.GetOrdinal("Usuario"));
                            Acceso.Contraseña = rd.GetString(rd.GetOrdinal("Contraseña"));
                            Acceso.Nombre = rd.GetString(rd.GetOrdinal("Nombre"));
                        }
                        return rd.HasRows;
                    }
                }
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
        }
    }
}
