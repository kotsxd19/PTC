using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto.Controlador.Validar
{
    internal class Incriptar
    {
        /// <summary>
        /// Calcula el hash SHA-256 de una cadena de texto.
        /// </summary>
        /// <param name="input">Texto a encriptar.</param>
        /// <returns>Hash SHA-256 en formato hexadecimal.</returns>
        public string ComputeSha256Hash(string rawData)
        {
            // Crear una instancia de SHA256 para calcular el hash
            using (SHA256 sha256Hash = SHA256.Create())
            {

                // Convertir la cadena de entrada en un arreglo de bytes utilizando codificación UTF-8
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                // Usar un StringBuilder para construir la representación en cadena del hash
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    // Convertir cada byte en una representación hexadecimal de 2 dígitos y agregarlo al StringBuilder
                    builder.Append(bytes[i].ToString("x2"));
                }

                // Devolver el hash como una cadena hexadecimal
                return builder.ToString();
            }
            
        }



        public string desifrarCadena(string cadenaCode)
        {
            try
            {
                byte[] decodedBytes = Convert.FromBase64String(cadenaCode);
                string decodedString = Encoding.UTF8.GetString(decodedBytes);
                return decodedString.ToString();
            }
            catch (Exception ex)
            {
                return $"Error al descifrar: {ex.Message}";
            }
        }


    }

   


}
