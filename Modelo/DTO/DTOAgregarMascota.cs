using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Modelo.DTO
{
    public class MascotaDAO
    {
        

        private string Nombre;
        private string Raza;
        private double Dueño;
        private string Peso;
        private DateTime FechaNacimiento;

        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public string Raza1 { get => Raza; set => Raza = value; }
        public double Dueño1 { get => Dueño; set => Dueño = value; }
        public string Peso1 { get => Peso; set => Peso = value; }
        public DateTime FechaNacimiento1 { get => FechaNacimiento; set => FechaNacimiento = value; }
    }
}
