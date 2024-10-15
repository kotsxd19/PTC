using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Modelo.DTO
{
    internal class DTOCitas : dbConexion
    {
        private int idCitas;
        private int idEmpleados;
        private string idMascota;
        private DateTime fecha;
        private TimeSpan hora;
        private string descripcion;

        public int IdCitas { get => idCitas; set => idCitas = value; }
        public int IdEmpleados { get => idEmpleados; set => idEmpleados = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public TimeSpan Hora { get => hora; set => hora = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string IdMascota1 { get => idMascota; set => idMascota = value; }
    }
}
