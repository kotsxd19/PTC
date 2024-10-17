using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Modelo.DAO
{
    internal class DTOMascotas : dbConexion
    {
        private int idcliente;
        private string raza;
        private string nombre;
        private decimal peso;
        private int genero;
        private bool estadoMascota;

        public string Nombre { get => nombre; set => nombre = value; }
        public decimal Peso { get => peso; set => peso = value; }
        public int Genero { get => genero; set => genero = value; }
        public bool EstadoMascota { get => estadoMascota; set => estadoMascota = value; }
        public string Raza { get => raza; set => raza = value; }
        public int Idcliente { get => idcliente; set => idcliente = value; }
    }
}
