using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Modelo.DTO
{
    internal class DTODetalleDeVentas : dbConexion
    {
        private int IdDetalleVenta;
        private int IdProducto;
        private int IdEmpleadoa;
        private int IdVenta;
        private int Total;
        private DateTime fehca;

        public int IdDetalleVenta1 { get => IdDetalleVenta; set => IdDetalleVenta = value; }
        public int IdProducto1 { get => IdProducto; set => IdProducto = value; }
        public int IdEmpleadoa1 { get => IdEmpleadoa; set => IdEmpleadoa = value; }
        public int IdVenta1 { get => IdVenta; set => IdVenta = value; }
        public int Total1 { get => Total; set => Total = value; }
        public DateTime Fehca { get => fehca; set => fehca = value; }
    }
}
