using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Modelo.DTO
{
    internal class DTOPrimerUso : dbConexion
    {
        private int IdEmpleado;
        private string nombre;
        private string apellido;
        private DateTime nacimiento;
        private int IdRoles;
        private string CorreoEmpleado;

        public int IdEmpleado1 { get => IdEmpleado; set => IdEmpleado = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public DateTime Nacimiento { get => nacimiento; set => nacimiento = value; }
        public int IdRoles1 { get => IdRoles; set => IdRoles = value; }
        public string CorreoEmpleado1 { get => CorreoEmpleado; set => CorreoEmpleado = value; }
    }
}
