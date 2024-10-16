using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto.Vista.AgregarUsuarios;
using Proyecto.Vista.Dueño;
using Proyecto.Vista.Inicio;
using Proyecto.Vista.Login;
using Proyecto.Vista.Mascota;
using Proyecto.Vista.PrimerUso;
using Proyecto.Vista.Proveedor;

namespace Proyecto
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
<<<<<<< HEAD
            Application.Run(new frmInicio());
=======
            Application.Run(new frmCrearPrimerUsuario());
>>>>>>> 394d122982c05afa2f38df7a91e6ce338d6bb4af
        }

        
    }
}
