using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Modelo.DTO
{
    internal class DTOProducto : dbConexion
    {
        int IdProducto;
        int IdProveedor;
        string CodigoDeBarra;
        string Nombre;
        decimal Precio;

        public int IdProducto1 { get => IdProducto; set => IdProducto = value; }
        public int IdProveedor1 { get => IdProveedor; set => IdProveedor = value; }
        public string CodigoDeBarra1 { get => CodigoDeBarra; set => CodigoDeBarra = value; }
        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public decimal Precio1 { get => Precio; set => Precio = value; }
    }
}
