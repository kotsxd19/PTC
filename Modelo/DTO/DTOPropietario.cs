using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Modelo.DTO
{
    internal class DTOPropietario : dbConexion
    {
        private int idPropietario;
        private string nombre;
        private string dui;
        private string apellido;
        private string telefono;
        private bool EstadoPropietario;

        public int IdPropietario { get => idPropietario; set => idPropietario = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Dui { get => dui; set => dui = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public bool EstadoPropietario1 { get => EstadoPropietario; set => EstadoPropietario = value; }
    }
}
