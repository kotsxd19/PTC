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

<<<<<<< Updated upstream
=======
            Application.Run(new frmInicio());

>>>>>>> Stashed changes
            Application.Run(new frmLogin());

            Application.Run(new frmCrearPrimerUsuario());

        }

        
    }
}
