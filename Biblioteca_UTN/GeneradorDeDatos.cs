using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_UTN
{
    public class GeneradorDeDatos
    {
        /// <summary>
        /// Genera fechas aleatorias.
        /// </summary>
        /// <returns>Devuelve una fecha posterior a 1970</returns>
        public static DateTime GenerarFechaAleatoria()
        {
            DateTime dtmFechaInicial = new DateTime(1970, 1, 1);
            Random aleatorio = new Random();
            int rangoDias = (DateTime.Today - dtmFechaInicial).Days;
            DateTime dtmFechaAleatoria = dtmFechaInicial.AddDays(aleatorio.Next(rangoDias));
            return (dtmFechaAleatoria);
        }
        /// <summary>
        /// Genera nombre masculinos y femeninos aleatorios.
        /// </summary>
        /// <returns>Devuelve un string con el nombre generado.</returns>
        public static string GenerarNombreAleatorio()
        {
            Random aleatorio = new Random();
            // Arreglo de nombres reales
            string[] strNombresReales =
                {
                "Alejandro", "Lucas","María", "Paola",
                "Fernanda", "Emiliano","Mauricio", "Fernando",
                "Francisco", "Mario", "Ángela","Fabiola",
                "Marcos", "Marta", "Raúl", "Octavio",
                "Marina", "German", "Martín", "Celeste",
                "Pablo", "Cristina", "Claudia","Mariana"
                };
            return (strNombresReales[aleatorio.Next(strNombresReales.Length)]); // Devuelve el valor string con los datos generados
        }
        /// <summary>
        /// Genera un numero de DNI aleatorio.
        /// </summary>
        /// <returns>Devuelve un valor entero entre los 8 y 44 millones</returns>
        public static int GenerarDNIAleatorio()
        {
            Random aleatorio = new Random();
            int dniAleatorio = aleatorio.Next(8000000, 44000000);
            return dniAleatorio; // Devuelve el valor int con los datos generados
        }
    }
}
