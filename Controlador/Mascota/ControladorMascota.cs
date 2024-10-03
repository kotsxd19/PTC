using Proyecto.Vista.AgregarMascotas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 
using Proyecto.Modelo.DAO;
using Proyecto.Modelo.DTO;
namespace Proyecto.Controlador.Mascota
{
    public class MascotaController
    {
        private MascotaDAO mascotaDAO = new MascotaDAO();

        public void AgregarMascota(DTOAgregarMascotas mascota)
        {
            mascotaDAO.InsertarMascota(mascota);
        }

        // Otros métodos: ObtenerMascotas, ActualizarMascota, EliminarMascota, etc.
    }
}
