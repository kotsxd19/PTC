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
    internal class DAOPrimerUso : DTOPrimerUso
    {
        readonly SqlCommand command = new SqlCommand();
        public bool RegistrarEmpleado()
        {
            try
            {
                command.Connection = getConnection();
                string query = "INSERT INTO Empleado VALUES (@param1, @param2, @param3)";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                cmd.Parameters.AddWithValue("param1", Nombre);
                cmd.Parameters.AddWithValue("param2", CorreoEmpleado1);
                int retorno = cmd.ExecuteNonQuery();
                return retorno > 0;
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Excepcion SQL: {ex.Message}", "Error al procesar información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Excepcion SQL: {ex.Message}", "Error al procesar información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                command.Connection.Close();
            }
        }

        /// <summary>
        /// El metodo se ejecuta al iniciar el programa
        /// </summary>
        /// <returns></returns>
        public int VerificarRegistroEmpleado()
        {
            try
            {
                command.Connection = getConnection();
                string query = "SELECT COUNT(*) FROM Empleado";
                SqlCommand cmd = new SqlCommand(query, command.Connection);
                int totalEmpresa = (int)cmd.ExecuteScalar();
                return totalEmpresa;
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
                command.Connection.Close();
            }
        }
    }
}
