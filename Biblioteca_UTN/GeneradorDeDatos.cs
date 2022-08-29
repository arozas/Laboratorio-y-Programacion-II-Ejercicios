using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_UTN
{
    public class GeneradorDeDatos
    {
        private static Random aleatorio;

        static GeneradorDeDatos()
        {

            aleatorio = new Random();
        }
        /// <summary>
        /// Genera fechas aleatorias.
        /// </summary>
        /// <returns>Devuelve una fecha posterior a 1970</returns>
        public static DateTime GenerarFechaAleatoria()
        {
            DateTime dtmFechaInicial = new DateTime(1970, 1, 1);
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
        /// Genera apellidos aleatorios.
        /// </summary>
        /// <returns>Devuelve un string con el apellido generado.</returns>
        public static string GenerarApellidoAleatorio()
        {
            // Arreglo de nombres reales
            string[] strApellidosReales =
                {
                "Mártinez", "Ródriguez","López", "Aguirre",
                "Garcia", "Gónzalez","Aguilar", "Fernandez",
                "Gimenez", "Herrera", "Guerra","Ortéga",
                "Ordoñez", "Mamani", "Rossi", "Rozas",
                "Rojas", "Quinteros", "Ponzio", "Almeida",
                "Gallardo", "Enriquez", "Solari","Diaz"
                };
            return (strApellidosReales[aleatorio.Next(strApellidosReales.Length)]); // Devuelve el valor string con los datos generados
        }



        /// <summary>
        /// Genera un numero entero aleatorio dentro del rango establecido.
        /// </summary>
        /// <param name="min">El valor minimo desde donde generará el numero</param>
        /// <param name="max">El valor maximo hasta donde generará el numero</param>
        /// <returns>Devuelve un valor entero</returns>
        public static int GenerarNumeroAleatorio(int min, int max)
        {
            int numeroAleatorio = aleatorio.Next(min, max);
            return numeroAleatorio; // Devuelve el valor int con los datos generados
        }
    }
}
