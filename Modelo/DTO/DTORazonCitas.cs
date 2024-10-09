using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Modelo.DTO
{
    internal class DTORazonCitas : dbConexion
    {
        private int IdRazon;
        private int IdCitas;

        public int IdRazon1 { get => IdRazon; set => IdRazon = value; }
        public int IdCitas1 { get => IdCitas; set => IdCitas = value; }
    }
}
