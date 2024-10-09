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
        private int IdMascota;
        private int IdEmpleado;
        private DateTime Hora;
        private DateTime Fecha;
        private string Descripcion;

        public int IdCitas1 { get => IdCitas; set => IdCitas = value; }
        public int IdMascota1 { get => IdMascota; set => IdMascota = value; }
        public int IdEmpleado1 { get => IdEmpleado; set => IdEmpleado = value; }
        public DateTime Hora1 { get => Hora; set => Hora = value; }
        public DateTime Fecha1 { get => Fecha; set => Fecha = value; }
        public string Descripcion1 { get => Descripcion; set => Descripcion = value; }
    }
}
