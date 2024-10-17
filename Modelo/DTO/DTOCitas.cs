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
        private int idMascota;
        private DateTime fecha;
        private TimeSpan hora;
        private string descripcion;
        private bool ESTADOCITA;

        public int IdCitas { get => idCitas; set => idCitas = value; }
        public int IdEmpleados { get => idEmpleados; set => idEmpleados = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public TimeSpan Hora { get => hora; set => hora = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int IdMascota1 { get => idMascota; set => idMascota = value; }
        public bool ESTADOCITA1 { get => ESTADOCITA; set => ESTADOCITA = value; }
    }
}
