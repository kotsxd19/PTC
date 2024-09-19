﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto.Modelo;


namespace Proyecto.Modelo.DTO
{
    internal class DTOCitas : dbConexion
    {
        private int idCitas;
        private int idEmpleados;
        private int idMascota;
        private DateTime fecha;
        private DateTime hora;
        private string descripcion;

        public int IdCitas { get => idCitas; set => idCitas = value; }
        public int IdEmpleados { get => idEmpleados; set => idEmpleados = value; }
        public int IdMascota { get => idMascota; set => idMascota = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public DateTime Hora { get => hora; set => hora = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
    }
}
