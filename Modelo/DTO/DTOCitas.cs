using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Modelo.DTO
{
    internal class DTOCitas : dbConexion
    {
        private int IdCitas;
        private int IdEmpleados;
        private int IdMascota;
        private DateTime Fecha;
        private DateTime Hora;
        private string Descripcion;

        public int IdCitas1 { get => IdCitas; set => IdCitas = value; }
        public int IdEmpleados1 { get => IdEmpleados; set => IdEmpleados = value; }
        public int IdMascota1 { get => IdMascota; set => IdMascota = value; }
        public DateTime Fecha1 { get => Fecha; set => Fecha = value; }
        public DateTime Hora1 { get => Hora; set => Hora = value; }
        public string Descripcion1 { get => Descripcion; set => Descripcion = value; }
    }
}
