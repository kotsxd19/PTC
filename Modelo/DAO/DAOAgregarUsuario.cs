using Proyecto.Modelo.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Modelo.DAO
{
    internal class DAOAgregarUsuario : DTOAgregarUsuario
    {
        readonly SqlCommand Command = new SqlCommand();

        public DataSet LlenarComboBox()
        {
            try
            {
                Command.Connection = getConnection();
                string query = "SELECT * FROM Roles";
                SqlCommand cmd = new SqlCommand(query, Command.Connection);
                cmd.EndExecuteNonQuery();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "Roles");
                return ds;
            }
            catch (Exception)
            {

                return null;
            }finally
            {
                getConnection().Close();
            }
        }

        public int IngresarUsuarios()
        {

        }
    }
}
