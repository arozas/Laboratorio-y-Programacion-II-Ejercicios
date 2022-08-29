using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_UTN
{
    public class Salida
    {
        /// <summary>
        /// Muestra mensaje de error "Numero Válido"
        /// </summary>
        public static void MensajeErrorNumero()
        {

            Console.WriteLine("Error. Ingrese un número válido");
        }
        /// <summary>
        /// Muestra mensaje de error "Numero fuera de rango"
        /// </summary>
        public static void MensajeErrorNumeroRango()
        {

            Console.WriteLine("Error. Ingrese un número dentro del rango.");
        }
        /// <summary>
        /// Muestra mensaje de error "Fecha no valida"
        /// </summary>
        public static void MensajeErrorFecha()
        {

            Console.WriteLine("Error. Ingrese una fecha válida");
            Console.WriteLine("Formato: dd/mm/aaaa (día/mes/año)");
        }
        /// <summary>
        /// Muestra un mensaje "Opcion no valida"
        /// </summary>
        public static void MensajeErrorOpcionValida()
        {

            Console.WriteLine("Error. No ingresó una opción válida.");
        }
        /// <summary>
        ///  Muestra mensaje de error. "No pudo realizar la operación".
        /// </summary>
        public static void MensajeErrorOperacion()
        {

            Console.WriteLine("Error. No se pudo realizar la operación.");
        }
    }
}
