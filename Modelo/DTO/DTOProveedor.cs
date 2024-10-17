using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Modelo.DTO
{
    internal class DTOProveedor : dbConexion
    {
        private int IdProveedor;
        private string proveedor;
        private bool EstadoProveedor;

        public int IdProveedor1 { get => IdProveedor; set => IdProveedor = value; }
        public string Proveedor { get => proveedor; set => proveedor = value; }
        public bool EstadoProveedor1 { get => EstadoProveedor; set => EstadoProveedor = value; }
    }
}
