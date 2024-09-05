using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Modelo.DTO
{
    internal class DTOAgregarUsuario
    {
        private int IdEmpleado;
        private string Nombre;
        private string Apellido;
        private DateTime FechaNacimiento;
        private string Usuario;
        private string Contraseña;

        public int IdEmpleado1 { get => IdEmpleado; set => IdEmpleado = value; }
        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public string Apellido1 { get => Apellido; set => Apellido = value; }
        public DateTime FechaNacimiento1 { get => FechaNacimiento; set => FechaNacimiento = value; }
        public string Usuario1 { get => Usuario; set => Usuario = value; }
        public string Contraseña1 { get => Contraseña; set => Contraseña = value; }
    }
}
