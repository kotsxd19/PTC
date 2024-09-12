using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Modelo.DTO

{

    internal class DTOAgregarMascotas : dbConexion

    {

        private int IdMascota;

        private int IdCliente;

        private int IdRaza;

        private string Nombre;

        private decimal Peso;

        private string Genero;

        private string Dueño;

        public int IdMascota1 { get => IdMascota; set => IdMascota = value; }

        public int IdCliente1 { get => IdCliente; set => IdCliente = value; }

        public int IdRaza1 { get => IdRaza; set => IdRaza = value; }

        public string Nombre1 { get => Nombre; set => Nombre = value; }

        public decimal Peso1 { get => Peso; set => Peso = value; }

        public string Genero1 { get => Genero; set => Genero = value; }
        public string Dueño1 { get => Dueño; set => Dueño = value; }

    }

}
