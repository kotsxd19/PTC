using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Modelo.DTO
{
    internal class DTORaza : dbConexion
    {
        private int IdRaza;
        private string TipoRaza;

        public int IdRaza1 { get => IdRaza; set => IdRaza = value; }
        public string TipoRaza1 { get => TipoRaza; set => TipoRaza = value; }
    }
}
