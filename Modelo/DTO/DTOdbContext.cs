using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Modelo.DTO
{
    internal class DTOdbContext
    {

        private static string clave;
        private static string vectorInicial;
        private static int saltos;

        private static string Servidor;
        private static string BaseDatos;
        private static string Usuario;
        private static string Contraseña;

        public static string Servidor1 { get => Servidor; set => Servidor = value; }
        public static string BaseDatos1 { get => BaseDatos; set => BaseDatos = value; }
        public static string Usuario1 { get => Usuario; set => Usuario = value; }
        public static string Contraseña1 { get => Contraseña; set => Contraseña = value; }
        public static string Clave { get => clave; set => clave = value; }
        public static string VectorInicial { get => vectorInicial; set => vectorInicial = value; }
        public static int Saltos { get => saltos; set => saltos = value; }
    }
}
