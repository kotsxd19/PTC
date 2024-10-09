using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Modelo.DTO
{
    internal class DTOMascota : dbConexion
    {
        private int IdMascota;
        private int IdCliente;
        private int peso;
        private string NombreMascota;
        private string Genero;
        private string Dueño;

        public int IdMascota1 { get => IdMascota; set => IdMascota = value; }
        public int IdCliente1 { get => IdCliente; set => IdCliente = value; }
        public int Peso { get => peso; set => peso = value; }
        public string NombreMascota1 { get => NombreMascota; set => NombreMascota = value; }
        public string Genero1 { get => Genero; set => Genero = value; }
        public string Dueño1 { get => Dueño; set => Dueño = value; }
    }
}
