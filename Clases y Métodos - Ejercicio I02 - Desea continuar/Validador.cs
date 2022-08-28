using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_y_Métodos___Ejercicio_I02___Desea_continuar
{
    public class Validador
    {
        /// <summary>
        /// Metodo que valida respuesta por el usuario por si o no.
        /// El enunciado del ejericio solicita que si no se preciona S se valide como respuesta negativa
        /// creo que para evitar errores o ingresos voluntario validar que aprete la tecla N.
        /// Por eso me desvié del enunciado.
        /// </summary>
        /// <param name="pregunta"> String conteniendo la pregunta a validar por si o no.</param>
        /// <returns>Retorna "true" en caso afirmativo, Retorna "false" en caso negativo.</returns>
        public static bool ValidarRespuesta(string pregunta)
        {
            bool retorno = false;
            ConsoleKeyInfo respuestaIngresada;
            do
            {
                Console.WriteLine($"\n{pregunta}");
                Console.WriteLine("<S/N>:");
                respuestaIngresada = Console.ReadKey();
                if (respuestaIngresada.Key == ConsoleKey.S)
                {
                    retorno = true;
                    Console.WriteLine("");
                }
                else if (respuestaIngresada.Key == ConsoleKey.N)
                {
                    retorno = false;
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine("\nERROR, DEBE INGRESAR UNA RESPUESTA <S/N>");
                }
            } while (respuestaIngresada.Key is not (ConsoleKey.S or ConsoleKey.N));

            return retorno;
        }
        /// <summary>
        /// Valida que el valor ingresado sea un numero de tipo int y que no sea empty o null.
        /// </summary>
        /// <param name="valorString">String donde se guarda el valor ingresado por el enunciado</param>
        /// <param name="valor">Variable donde se devuelve el valor ingresado en el string en el caso que el parseo sea exitoso.</param>
        /// <returns>retorna "true" en el caso que el valor sea del tipo int, si no retorna "false"</returns>
        public static bool EsNumero(string valorString, out int valor)
        {
            int auxiliar = 0;
            bool retorno = !string.IsNullOrEmpty(valorString) && int.TryParse(valorString, out auxiliar);
            valor = auxiliar;
            return retorno;
        }
        /// <summary>
        /// Valida que el valor ingresado sea un numero de tipo float y que no sea empty o null.
        /// </summary>
        /// <param name="valorString">String donde se guarda el valor ingresado por el enunciado</param>
        /// <param name="valor">Variable donde se devuelve el valor ingresado en el string en el caso que el parseo sea exitoso.</param>
        /// <returns>retorna "true" en el caso que el valor sea del tipo float, si no retorna "false"</returns>
        public static bool EsNumero(string valorString, out float valor)
        {
            float auxiliar = 0;
            bool retorno = !string.IsNullOrEmpty(valorString) && float.TryParse(valorString, out auxiliar);
            valor = auxiliar;
            return retorno;
        }
        /// <summary>
        /// Valida que el valor ingresado sea un numero de tipo double y que no sea empty o null.
        /// </summary>
        /// <param name="valorString">String donde se guarda el valor ingresado por el enunciado</param>
        /// <param name="valor">Variable donde se devuelve el valor ingresado en el string en el caso que el parseo sea exitoso.</param>
        /// <returns>retorna "true" en el caso que el valor sea del tipo double, si no retorna "false"</returns>
        public static bool EsNumero(string valorString, out double valor)
        {
            double auxiliar = 0;
            bool retorno = !string.IsNullOrEmpty(valorString) && double.TryParse(valorString, out auxiliar);
            valor = auxiliar;
            return retorno;
        }
    }
}
