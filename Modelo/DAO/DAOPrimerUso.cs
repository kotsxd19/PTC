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
    internal class DAOPrimerUso : DTOPrimerUso
    {
        readonly SqlCommand command = new SqlCommand();
        public bool RegistrarEmpleado()
        {
            try
            {
                // Establecer la conexión a la base de datos
                command.Connection = getConnection();

                // Consulta SQL para insertar un nuevo registro en la tabla Empleado
                string query = "INSERT INTO Empleado (Nombre, CorreoEmpleado) VALUES (@Nombre, @CorreoEmpleado)";
                SqlCommand cmd = new SqlCommand(query, command.Connection);

                // Asignar los valores a los parámetros de la consulta
                cmd.Parameters.AddWithValue("@Nombre", Nombre);
                cmd.Parameters.AddWithValue("@CorreoEmpleado", CorreoEmpleado1);

                // Ejecutar la consulta
                int retorno = cmd.ExecuteNonQuery();

                // Verificar si se ha realizado la inserción
                return retorno > 0;
            }
            catch (SqlException ex)
            {
                // Mostrar mensaje de error para excepciones SQL
                MessageBox.Show($"Excepción SQL: {ex.Message}", "Error al procesar la información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (Exception ex)
            {
                // Mostrar mensaje de error para excepciones generales
                MessageBox.Show($"Excepción: {ex.Message}", "Error al procesar la información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                // Cerrar la conexión independientemente del resultado
                if (command.Connection != null && command.Connection.State == ConnectionState.Open)
                {
                    command.Connection.Close();
                }
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
                // Establecer la conexión a la base de datos
                command.Connection = getConnection();

                // Consulta SQL para contar el número de registros en la tabla Empleado
                string query = "SELECT COUNT(*) FROM Empleado";
                SqlCommand cmd = new SqlCommand(query, command.Connection);

                // Ejecutar la consulta y obtener el resultado
                int totalEmpresa = (int)cmd.ExecuteScalar();

                // Devolver el total de registros
                return totalEmpresa;
            }
            catch (SqlException ex)
            {
                // Mostrar mensaje de error para excepciones SQL
                MessageBox.Show($"Excepción SQL: {ex.Message}", "Error al procesar la información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
            catch (Exception ex)
            {
                // Mostrar mensaje de error para excepciones generales
                MessageBox.Show($"Excepción: {ex.Message}", "Error al procesar la información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
            finally
            {
                // Cerrar la conexión si está abierta
                if (command.Connection != null && command.Connection.State == ConnectionState.Open)
                {
                    command.Connection.Close();
                }
            }
        }

    }
}
