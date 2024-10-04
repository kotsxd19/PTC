using Proyecto.Modelo.DAO;
using Proyecto.Vista.AgregarUsuarios;
using Proyecto.Vista.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto.Controlador.Validar
{
    internal class Acceso
    {
        private static string usuario = string.Empty;
        private static string contraseña = string.Empty;
        private static string nombre = string.Empty;
        private static int roleId;
        private static string access = string.Empty;



        public static string Usuario { get => usuario; set => usuario = value; }
        public static string Contraseña { get => contraseña; set => contraseña = value; }
        public static string Nombre {get => nombre; set => nombre = value;}
        public static int RoleId { get => roleId; set => roleId = value; }
        public static string Access { get => access; set => access = value; }
    }
}
