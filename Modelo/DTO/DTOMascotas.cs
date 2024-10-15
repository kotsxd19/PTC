using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Modelo.DAO
{
    internal class DTOMascotas : dbConexion
    {
        private int idmascota;
        private int idcliente;
        private int idraza;
        private string nombre;
        private string peso;
        private string genero;
        private string dueño;

        public int Idmascota { get => idmascota; set => idmascota = value; }
        public int Idcliente { get => idcliente; set => idcliente = value; }
        public int Idraza { get => idraza; set => idraza = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Peso { get => peso; set => peso = value; }
        public string Genero { get => genero; set => genero = value; }
        public string Dueño { get => dueño; set => dueño = value; }

    }
}
