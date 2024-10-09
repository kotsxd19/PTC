using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Modelo.DTO
{
    internal class DTOVentas : dbConexion
    {
        private int IdVentas;
        private int IdProductos;
        private int IdCitas;

        public int IdVentas1 { get => IdVentas; set => IdVentas = value; }
        public int IdProductos1 { get => IdProductos; set => IdProductos = value; }
        public int IdCitas1 { get => IdCitas; set => IdCitas = value; }
    }
}
