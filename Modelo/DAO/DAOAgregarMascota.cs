using Proyecto.Modelo.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
namespace Proyecto.Modelo.DAO
{
    internal class DAOAgregarMascotas : DTOAgregarMascotas
    {
        SqlCommand command = new SqlCommand();
    }
}