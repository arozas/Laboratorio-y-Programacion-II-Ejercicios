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
        public static void MensajeErrorOpcióonValida()
        {

            Console.WriteLine("Error. No ingresó una opción válida.");
        }
    }
}
