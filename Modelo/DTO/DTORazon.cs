using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Modelo.DTO
{
    internal class DTORazon :dbConexion 
    {
        private int IdRazon;
        private string NombreRazon;

        public int IdRazon1 { get => IdRazon; set => IdRazon = value; }
        public string NombreRazon1 { get => NombreRazon; set => NombreRazon = value; }
    }
}
